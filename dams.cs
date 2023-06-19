using System;
using System.Collections.Generic;

// User class representing a user in the social network
class User
{
    private string username;
    private List<User> friends;

    public User(string username)
    {
        this.username = username;
        friends = new List<User>();
    }

    public string GetUsername()
    {
        return username;
    }

    public void AddFriend(User friendUser)
    {
        friends.Add(friendUser);
    }

    public void DisplayFriends()
    {
        Console.WriteLine($"Friends of {username}:");
        foreach (var friendUser in friends)
        {
            Console.WriteLine($"- {friendUser.GetUsername()}");
        }
    }
}

// SocialNetwork class representing the social network
class SocialNetwork
{
    private List<User> users;

    public SocialNetwork()
    {
        users = new List<User>();
    }

    public User CreateUser(string username)
    {
        User user = new User(username);
        users.Add(user);
        return user;
    }

    public void AddFriendship(User user1, User user2)
    {
        user1.AddFriend(user2);
        user2.AddFriend(user1);
    }

    public void DisplayUsers()
    {
        Console.WriteLine("Dams in the Social Network:");
        foreach (var user in users)
        {
            Console.WriteLine($"- {user.GetUsername()}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SocialNetwork socialNetwork = new SocialNetwork();

        // Create users
        User user1 = socialNetwork.CreateUser("Alice");
        User user2 = socialNetwork.CreateUser("Bob");
        User user3 = socialNetwork.CreateUser("Charlie");

        // Establish friendships
        socialNetwork.AddFriendship(user1, user2);
        socialNetwork.AddFriendship(user1, user3);

        // Display users and their friends
        socialNetwork.DisplayUsers();
        user1.DisplayFriends();
    }
}
