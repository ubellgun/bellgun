package io.namoosori.rest.store.logic;

import io.namoosori.rest.entitiy.User;
import io.namoosori.rest.store.UserStore;
import org.springframework.stereotype.Repository;

import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;

@Repository
public class UserStoreLogic implements UserStore {

    private Map<String, User> userMap;

    public UserStoreLogic(){
        this.userMap= new HashMap<>();

    }
    @Override
    public String create(User newUser) {
        this.userMap.put(newUser.getId(),newUser);
        return newUser.getId();
    }

    @Override
    public void update(User newUser) {
       this.userMap.put(newUser.getId(),newUser);
    }

    @Override
    public void delete(String id) {
         this.userMap.remove(id);
    }

    @Override
    public User retrieve(String id) {


        return this.userMap.get(id);
    }

    @Override
    public List<User> retrieveAll() {
        return this.userMap.values().stream().collect(Collectors.toList());
    }
}
