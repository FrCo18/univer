package com.vyatsu.task14.configuration;

import org.springframework.security.config.annotation.authentication.builders.AuthenticationManagerBuilder;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;

public interface SecurityConfigInterface {

    void configure(AuthenticationManagerBuilder auth) throws Exception;

    void configure(HttpSecurity http) throws Exception;
}
