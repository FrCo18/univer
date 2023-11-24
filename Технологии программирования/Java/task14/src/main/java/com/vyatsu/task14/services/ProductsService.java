package com.vyatsu.task14.services;

import com.vyatsu.task14.entities.Filter;
import com.vyatsu.task14.entities.Product;
import com.vyatsu.task14.entities.ProductSpecification;
import com.vyatsu.task14.repositories.ProductRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.PageRequest;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.domain.Specification;
import org.springframework.stereotype.Service;

import java.util.Locale;

@Service
public class ProductsService {
    @Autowired
    private ProductRepository productRepository;

    public Product getById(Long id) {
        return productRepository.findById(id).get();
    }

    public Page<Product> getAllProducts(Pageable pageable) {
        return productRepository.findAll(pageable);
    }

    public Page<Product> getFilterProducts(Filter filter, Pageable pageable){
        int min;
        try{
            min = Math.toIntExact(filter.getMinPrice());
        }catch (Exception e){
            min = 0;
        }
        int max;
        try{
            max = Math.toIntExact(filter.getMaxPrice());
        }catch (Exception e){
            max = 100000;
        }

        String text = filter.getText();
        return (Page<Product>) productRepository
                .findAll(Specification
                        .where(ProductSpecification.minValue(min))
                        .and(ProductSpecification.maxValue(max))
                        .and(ProductSpecification
                                .hasText(text.toLowerCase(Locale.ROOT))), pageable);
    }


    public void save(Product product) {
        productRepository.save(product);
    }

    public void add(Product product) {
        productRepository.save(product);
    }
}
