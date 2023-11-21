package com.vyatsu.task14.services;

import com.vyatsu.task14.entities.Product;
import com.vyatsu.task14.repositories.ProductRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class ProductsService {
    private ProductRepository productRepository;

    @Autowired
    public void setProductRepository(ProductRepository productRepository) {
        this.productRepository = productRepository;
    }

    public Product getById(Long id) {
        return productRepository.findById(id);
    }

    public List<Product> getAllProducts() {
        return productRepository.findAll();
    }

    public List<Product> getProductsByPage(int page) {
        int skip = page * 10;
        List<Product> allProducts = productRepository.findAll();

        if (skip > allProducts.size()) {
            return new ArrayList<>();
        }
        if (allProducts.size() < skip + 10) {
            return allProducts.subList(skip, allProducts.size());
        }
        return allProducts.subList(skip, skip + 10);
    }

    public int getCountPages() {
        return productRepository.findAll().size() / 10;
    }

    public void add(Product product) {
        productRepository.save(product);
    }
}
