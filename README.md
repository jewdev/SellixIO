# SellixIO
 A [Sellix.io]("https://sellix.io") wrapper in C#

# Installation
## Download the DLL and import it to your project.
## [Download here]("https://github.com/jewdev/SellixIO/releases/latest")

## (Installation via nuget - SOON!)

# Usage

```c#
using System;

// Imports the library from the DLL.
using SellixIO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Makes the variable "api" a bridge that contacts Sellix's servers.
            Sellix api = new Sellix("api_key_here");

            // Prints the whole blacklist.
            Console.WriteLine(api.GetAllBlacklist());
        }
    }
}
```

# Available functions

## Blacklist
### GetAllBlacklist()
Get blacklist

### GetBlacklist(string uniqid)
Get a blacklist by id

## Category
### GetAllCategories()
Get all categories

### GetCategory(string uniqid)
Get a specific category

## Coupon
### GetAllCoupons()
Get all coupons

### GetCoupon(string uniqid)
Get a specific coupon

## Feedback
### GetAllFeedbacks()
Get all feedbacks

### GetFeedback(string uniqid)
Get a specific feedback

## Order
### GetAllOrders()
Get all orders

### GetOrder(string uniqid)
Get a specific order

## Product
### GetAllProducts()
Get all products

### GetProduct(string uniqid)
Get a specific product

## Query
### GetAllQueries()
Get all queries

### GetQuery(string uniqid)
Get a specific query
