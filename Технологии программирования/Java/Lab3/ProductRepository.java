package com.vyatsu.task16.repositories;
import com.vyatsu.task16.entities.Product;
import org.springframework.data.jpa.repository.JpaSpecificationExecutor;
import org.springframework.data.repository.PagingAndSortingRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface ProductRepository extends PagingAndSortingRepository<Product,Long>, JpaSpecificationExecutor<Product> {
}
