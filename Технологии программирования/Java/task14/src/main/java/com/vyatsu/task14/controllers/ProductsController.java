package com.vyatsu.task14.controllers;

import com.vyatsu.task14.entities.Filter;
import com.vyatsu.task14.entities.Product;
import com.vyatsu.task14.services.ProductsService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.domain.Sort;
import org.springframework.data.web.PageableDefault;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import javax.annotation.PostConstruct;
import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

@Controller
@RequestMapping("/")
public class ProductsController {
    @Autowired
    private ProductsService productsService;

    private Filter filter;

    @PostConstruct
    public void post() {
        filter = new Filter();
    }

    @GetMapping
    public String showProductsList(
            Model model,
            @RequestParam(required = false, defaultValue = "", name = "minPrice") String min,
            @RequestParam(required = false, defaultValue = "", name = "maxPrice") String max,
            @RequestParam(required = false, defaultValue = "", name = "text") String text,
            @PageableDefault(sort = {"id"}, direction = Sort.Direction.ASC, size = 5) Pageable pageable
    ) {
        Page<Product> page;
        if ((min != null && !min.isEmpty()) || (max != null && !max.isEmpty()) || (text != null && !text.isEmpty())) {
            if (min != null && !min.isEmpty()) filter.setMinPrice((long) Integer.parseInt(min));
            if (max != null && !max.isEmpty()) filter.setMaxPrice((long) Integer.parseInt(max));
            if (text != null && !text.isEmpty()) filter.setText(text);
            page = productsService.getFilterProducts(filter, pageable);
        } else {
            page = productsService.getAllProducts(pageable);
        }
        Product product = new Product();
        model.addAttribute("products", page);
        model.addAttribute("product", product);
        model.addAttribute("filter", filter);
        model.addAttribute("numberOfPage", page.getTotalPages());
        if (page.getTotalPages() > 0) {
            List<Integer> pageNumbers = IntStream.rangeClosed(1, (int) page.getTotalPages())
                    .boxed()
                    .collect(Collectors.toList());
            model.addAttribute("pageNumbers", pageNumbers);
        }
        return "products";
    }

    @PostMapping("/add")
    public String addProduct(@RequestParam(value = "Name") String Name,
                             @RequestParam(value = "Price") Integer Price) {
        Product product = new Product();
        product.setTitle(Name);
        product.setPrice(Price);
        productsService.save(product);
        return "redirect:/";
    }

    @GetMapping("/show/{id}")
    public String showOneProduct(Model model, @PathVariable(value = "id") Long id) {
        Product product = productsService.getById(id);
        model.addAttribute("product", product);
        return "product-page";
    }
}
