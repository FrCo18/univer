package com.vyatsu.task14.models;

import java.math.BigDecimal;

public class FilterProduct {
    private String title;
    private BigDecimal priceLess;
    private BigDecimal priceMax;
    public FilterProduct(String title, BigDecimal priceLess, BigDecimal priceMax) {
        this.title = title;
        this.priceLess = priceLess;
        this.priceMax = priceMax;
    }

    public BigDecimal getPriceLess() {
        return priceLess;
    }

    public void setPriceLess(BigDecimal priceLess) {
        this.priceLess = priceLess;
    }

    public BigDecimal getPriceMax() {
        return priceMax;
    }

    public void setPriceMax(BigDecimal priceMax) {
        this.priceMax = priceMax;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }
}
