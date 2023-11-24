package com.vyatsu.task14.configuration;

import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;
import org.springframework.data.jpa.repository.config.EnableJpaRepositories;
import org.springframework.transaction.annotation.EnableTransactionManagement;

@Configuration
@ComponentScan("com.vyatsu.task14")
@EnableJpaRepositories("com.vyatsu.task14.repositories")
@EnableTransactionManagement
public class AppConfig {

}