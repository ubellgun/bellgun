package io.namoosori.rest.service.logic;

import io.namoosori.rest.entitiy.User;
import io.namoosori.rest.service.UserService;
import io.namoosori.rest.store.UserStore;
import io.namoosori.rest.store.logic.UserStoreLogic;
import lombok.RequiredArgsConstructor;

import org.springframework.stereotype.Service;

import java.util.List;
@Service
@RequiredArgsConstructor
public class UserServiceLogic implements UserService {
    private final UserStore userStore;


    @Override
    public String register(User newUser) {
        return this.userStore.create(newUser);
    }

    @Override
    public void modify(User newUser) {
this.userStore.update(newUser);
    }

    @Override
    public void remove(String id) {
this.userStore.delete(id);
    }

    @Override
    public User find(String id) {
        return this.userStore.retrieve(id);
    }

    @Override
    public List<User> findAll() {
        return this.userStore.retrieveAll();
    }
}
