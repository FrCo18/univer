package com.vyatsu.task14.services;

import com.vyatsu.task14.entities.Product;
import com.vyatsu.task14.models.FilterProduct;
import com.vyatsu.task14.models.ProductSpecs;
import com.vyatsu.task14.repositories.ProductRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.jpa.domain.Specification;
import org.springframework.stereotype.Service;

import java.math.BigDecimal;
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
        return productRepository.findById(id).get();
    }

    public List<Product> getAllProducts(FilterProduct filterProduct) {
        return filterProducts(filterProduct);
    }

    public List<Product> getProductsByPage(int page, FilterProduct filterProduct) {
        int skip = page * 10;
        List<Product> allProducts = filterProducts(filterProduct);

        if (skip > allProducts.size()) {
            return new ArrayList<>();
        }
        if (allProducts.size() < skip + 10) {
            return allProducts.subList(skip, allProducts.size());
        }
        return allProducts.subList(skip, skip + 10);
    }

    private List<Product> filterProducts(FilterProduct filterProduct) {
        if (filterProduct.getTitle() == null) {
            filterProduct.setTitle("");
        }
        if (filterProduct.getPriceLess() == null) {
            filterProduct.setPriceLess(BigDecimal.valueOf(Integer.MAX_VALUE));
        }

        if (filterProduct.getPriceMax() == null) {
            filterProduct.setPriceMax(BigDecimal.valueOf(Integer.MIN_VALUE));
        }
        List <Product> filteredProducts = (List<Product>) productRepository.findAll(
                Specification.where(ProductSpecs.titleContainsWord(filterProduct.getTitle())
                        .and(ProductSpecs.priceLesserThanOrEq(filterProduct.getPriceLess())
                                .and(ProductSpecs.priceGreaterThanOrEq(filterProduct.getPriceMax())
                                )
                        )
                )
        );
        return filteredProducts;
    }

    public int getCountPages() {
        List<Product> allProducts = (List<Product>) productRepository.findAll();
        return allProducts.size() / 10;
    }

    public void add(Product product) {
        productRepository.save(product);
    }
}
