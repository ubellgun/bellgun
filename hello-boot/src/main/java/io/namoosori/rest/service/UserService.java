package io.namoosori.rest.service;

import io.namoosori.rest.entitiy.User;

import java.util.List;

public interface UserService {
    String register(User newUser);
    void modify(User newUser);
    void remove(String id);

    User find(String id);
    List<User> findAll();
}
