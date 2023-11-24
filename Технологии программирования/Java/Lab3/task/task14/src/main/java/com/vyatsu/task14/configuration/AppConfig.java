package com.vyatsu.task14.configuration;

import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;
import org.springframework.data.jpa.repository.config.EnableJpaRepositories;
import org.springframework.transaction.annotation.EnableTransactionManagement;

@Configuration
@EnableJpaRepositories("com.vyatsu.task14.repositories")
@ComponentScan("com.vyatsu.task14")
@EnableTransactionManagement
public class AppConfig {
}