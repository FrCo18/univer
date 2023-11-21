package com.vyatsu.task14.controllers;

import com.vyatsu.task14.entities.Product;
import com.vyatsu.task14.services.ProductsService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@Controller
@RequestMapping("/products")
public class ProductsController {
    private ProductsService productsService;

    @Autowired
    public void setProductsService(ProductsService productsService) {
        this.productsService = productsService;
    }

    @GetMapping
    public String showProductsList(Model model) {
        Product product = new Product();
        List<Product> allProducts = productsService.getAllProducts();
        model.addAttribute("products", allProducts);
        model.addAttribute("product", product);
        model.addAttribute("page", 0);
        model.addAttribute("countPages", 0);
        model.addAttribute("countProducts", allProducts.size());

        return "products";
    }

    @GetMapping("/{page}")
    public String showProductsListByPage(Model model, @PathVariable(value = "page") int page) {
        Product product = new Product();
        model.addAttribute("products", productsService.getProductsByPage(page));
        model.addAttribute("product", product);
        model.addAttribute("countPages", productsService.getCountPages());
        model.addAttribute("countProducts", productsService.getAllProducts().size());
        model.addAttribute("page", page);
        return "products";
    }

    @PostMapping("/add")
    public String addProduct(@ModelAttribute(value = "product") Product product, @ModelAttribute(value = "page") int page) {
        productsService.add(product);
        return "redirect:/products/" + page;
    }

    @GetMapping("/show/{id}")
    public String showOneProduct(Model model, @PathVariable(value = "id") Long id) {
        Product product = productsService.getById(id);
        model.addAttribute("product", product);
        return "product-page";
    }
}
