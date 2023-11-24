package com.vyatsu.task14.controllers;

import com.vyatsu.task14.entities.Product;
import com.vyatsu.task14.models.FilterProduct;
import com.vyatsu.task14.services.ProductsService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import java.math.BigDecimal;
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
    public String showProductsList(
            Model model,
            @RequestParam(required = false) String page,
            @RequestParam(required = false) String title,
            @RequestParam(required = false) BigDecimal priceGreat,
            @RequestParam(required = false) BigDecimal priceLess
    ) {
        FilterProduct filterProduct = new FilterProduct(title, priceLess, priceGreat);
        List<Product> allProducts = productsService.getAllProducts(filterProduct);
        if (page == null && allProducts.size() <= 10) {
            showAllProducts(model, allProducts);
            return "products";
        }

        if (page == null) {
            page = "0";
        }
        showProductsListByPage(model, allProducts, Integer.parseInt(page), filterProduct);

        return "products";
    }

    private void showAllProducts(Model model, List<Product> allProducts) {
        Product product = new Product();
        model.addAttribute("products", allProducts);
        model.addAttribute("product", product);
        model.addAttribute("page", 0);
        model.addAttribute("countPages", 0);
        model.addAttribute("countProducts", allProducts.size());
    }

    private void showProductsListByPage(Model model, List<Product> allProducts, int page, FilterProduct filterProduct) {
        Product product = new Product();
        model.addAttribute("products", productsService.getProductsByPage(page, filterProduct));
        model.addAttribute("product", product);
        model.addAttribute("countPages", productsService.getCountPages());
        model.addAttribute("countProducts", allProducts.size());
        model.addAttribute("page", page);
    }

    @PostMapping("/add")
    public String addProduct(@ModelAttribute(value = "product") Product product, @ModelAttribute(value = "page") int page) {
        productsService.add(product);
        return "redirect:/products/?page=" + page;
    }

    @GetMapping("/show/{id}")
    public String showOneProduct(Model model, @PathVariable(value = "id") Long id) {
        Product product = productsService.getById(id);
        model.addAttribute("product", product);
        return "product-page";
    }
}
