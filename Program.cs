using System;

//Sean Botha - 577288
//Conrad Joubert - 577417
//Edwin le Cointre - 577328
//Frank Peter Smal - 577298
//Justin Gibbon - 577407

namespace Project2
{
    internal class Program
    {
        static string order = "";
        static int total = 0;
        static int option = 0;
        static void Main(string[] args)
        {
            int terminate = 1;

            while (terminate != 0)
            {
                Console.WriteLine("---Welcome Belgium Fast Foods---\n");
                switchMethod();
                Console.WriteLine("Your order is:\n" + order);
                Console.WriteLine("Your total is: R" + total);
                Console.WriteLine("\n---Goodbye, enjoy your day :)---");
                order = "";
                total = 0;
                Console.WriteLine("Press 0 to exit the program");
                terminate = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }

        //Sean - Switch method
        static void switchMethod()
        {
        mainMenu:
            Console.WriteLine("Enter what type of food you want:\n1:Burgers\n2:Pizzas\n3:Wraps\n4:Drinks\n0:Checkout");
            option = Convert.ToInt32(Console.ReadLine());

            while (option != 0)
            {
                switch ((type)option)
                {
                    case type.checkOut:
                        break;

                    case type.burgers:
                        Console.WriteLine("Enter type of burger:" +
                            "\n1:Beef Burger - R65" +
                            "\n2:Chicken Burger - R70" +
                            "\n3:Rib Burger - R90" +
                            "\n4:Hawaiian Burger - R75" +
                            "\n5:Mushroom Burger - R80" +
                            "\n6:Gourmet Burger - R110" +
                            "\n7:Vegan Burger - R100" +
                            "\n8:Add Chips - R15" +
                            "\n0:Back");
                        int burger = Convert.ToInt32(Console.ReadLine());

                        switch ((burgers)burger)
                        {
                            case burgers.back:
                                goto mainMenu;
                                break;

                            case burgers.Beef_Burger:
                                order += "Beef Burger\n";
                                total += 65;
                                break;

                            case burgers.Chicken_burger:
                                order += "Chicken Burger\n";
                                total += 65;
                                break;

                            case burgers.Hawaiian_burger:
                                order += "Hawaiian Burger\n";
                                total += 75;
                                break;

                            case burgers.Rib_burger:
                                order += "Rib Burger\n";
                                total += 90;
                                break;

                            case burgers.Mushroom_Burger:
                                order += "Musroom Burger\n";
                                total += 80;
                                break;

                            case burgers.Gourmet_burger:
                                order += "Gourmet Burger\n";
                                total += 110;
                                break;

                            case burgers.Vegans_burger:
                                order += "Vegan Burger\n";
                                total += 100;
                                break;

                            case burgers.add_Chips:
                                order += "with chips\n";
                                total += 15;
                                break;

                            default:
                                Console.WriteLine("Invalid option chosen");
                                break;
                        }
                        break;

                    case type.pizza:
                        Console.WriteLine("Enter type of pizza:" +
                            "\n1:Meaty Pizza - R90" +
                            "\n2:Chicken Pizza - R95" +
                            "\n3:Vegatarian Pizza - R110" +
                            "\n4:Greek Pizza - R100" +
                            "\n5:Margherita - R85" +
                            "\n6:Seafood Pizza - R150" +
                            "\n7:Pepperoni Pizza - R75" +
                            "\n8:Cheese Pizza - R60" +
                            "\n9:Hawaiian Pizza - R65" +
                            "\n0:Back");
                        int pizzas = Convert.ToInt32(Console.ReadLine());

                        switch ((pizza)pizzas)
                        {
                            case pizza.back:
                                goto mainMenu;
                                break;

                            case pizza.Meaty_pizza:
                                order += "Meaty Pizza\n";
                                total += 90;
                                break;

                            case pizza.chicken_pizza:
                                order += "Chicken Pizza\n";
                                total += 95;
                                break;

                            case pizza.vegetarian_pizza:
                                order += "Vegetarian Pizza\n";
                                total += 110;
                                break;

                            case pizza.Greek_Pizza:
                                order += "Greek Pizza\n";
                                total += 85;
                                break;

                            case pizza.Margherita_pizza:
                                order += "Margherita Pizza\n";
                                total += 85;
                                break;

                            case pizza.seafood_pizza:
                                order += "Seafood Pizza\n";
                                total += 150;
                                break;

                            case pizza.pepperoni_pizza:
                                order += "Pepperoni Pizza\n";
                                total += 75;
                                break;

                            case pizza.cheese_pizza:
                                order += "Cheese Pizza\n";
                                total += 60;
                                break;

                            case pizza.hawaiian_pizza:
                                order += "Hawaiian Pizza\n";
                                total += 65;
                                break;

                            default:
                                Console.WriteLine("Invalid option chosen");
                                break;
                        }
                        break;

                    case type.wraps:
                        Console.WriteLine("Enter type of wrap:" +
                            "\n1:Beef Wrap - R55" +
                            "\n2:Chicken Wrap - R50" +
                            "\n3:Bacon, Avo and Feta Wrap - R80" +
                            "\n4:Cheesy Chilly and Beef Wrap - R65" +
                            "\n5:Vegan Wrap - R65" +
                            "\n6:Mediteranian Wrap - R85" +
                            "\n0:Back");
                        int wrap = Convert.ToInt32(Console.ReadLine());

                        switch ((wraps)wrap)
                        {
                            case wraps.back:
                                goto mainMenu;
                                break;

                            case wraps.Beef_wrap:
                                order += "Beef Wrap\n";
                                total += 55;
                                break;

                            case wraps.Chicken_wrap:
                                order += "Chicken Wrap\n";
                                total += 50;
                                break;

                            case wraps.Bacon_avo_and_feta_wrap:
                                order += "Bacon, Avo and Feta Wrap\n";
                                total += 80;
                                break;

                            case wraps.Cheesy_chilly_beef_wrap:
                                order += "Cheesy Chilly and Beef Wrap\n";
                                total += 55;
                                break;

                            case wraps.Vegan_wrap:
                                order += "Vegan Wrap\n";
                                total += 65;
                                break;

                            case wraps.Mediteranian_wrap:
                                order += "Mediteranian Wrap\n";
                                total += 85;
                                break;

                            default:
                                Console.WriteLine("Invalid option chosen");
                                break;
                        }
                        break;

                    case type.drinks:
                        Console.WriteLine("Enter type of drink:" +
                            "\n1:Coke - R15" +
                            "\n2:Sprite - R12" +
                            "\n3:Cream Soda - R10" +
                            "\n4:Pepsi - R13" +
                            "\n5:Lemon Twist - R14" +
                            "\n6:Granadilla Twist - R14" +
                            "\n7:Iron Brew - R11" +
                            "\n8:Mountain Dew - R12" +
                            "\n9:Banana Milkshake - 25" +
                            "\n10:Strawberry Milkshake - R22" +
                            "\n11:Chocolate Milkshake - R25" +
                            "\n0:Back");
                        int drink = Convert.ToInt32(Console.ReadLine());

                        switch ((drinks)drink)
                        {
                            case 0:
                                goto mainMenu;
                                break;

                            case drinks.Coke:
                                order += "Coke\n";
                                total += 15;
                                break;

                            case drinks.Sprite:
                                order += "Sprite\n";
                                total += 12;
                                break;

                            case drinks.Cream_Soda:
                                order += "Cream Soda\n";
                                total += 10;
                                break;

                            case drinks.Pepsi:
                                order += "Pepsi\n";
                                total += 13;
                                break;

                            case drinks.Lemon_Twist:
                                order += "Lemon Twist\n";
                                total += 14;
                                break;

                            case drinks.Granadilla_Twist:
                                order += "Granadilla Twist\n";
                                total += 14;
                                break;

                            case drinks.Iron_Brew:
                                order += "Iron Brew\n";
                                total += 11;
                                break;

                            case drinks.Mountain_Dew:
                                order += "Mountain Dew\n";
                                total += 12;
                                break;

                            case drinks.Banana_Milkshake:
                                order += "Banana Milkshake\n";
                                total += 25;
                                break;

                            case drinks.Strawberry_Milkshake:
                                order += "Strawberry Milkshake\n";
                                total += 22;
                                break;

                            case drinks.Chocolate_Milkshake:
                                order += "Chocolate Milkshake\n";
                                total += 25;
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid option entered");
                        break;
                }
                Console.WriteLine("Enter what type of food you want:\n1:Burgers\n2:Pizzas\n3:Wraps\n4:Drinks\n0:Checkout");
                option = Convert.ToInt32(Console.ReadLine());
            }
        }

        enum type
        {
            checkOut, 
            burgers, 
            pizza, 
            wraps, 
            drinks
        }

        //Conrad - burgers
        enum burgers
        {
            back,
            Beef_Burger,//R65
            Chicken_burger, //R70
            Rib_burger,//R90
            Hawaiian_burger, //R75
            Mushroom_Burger, //R80
            Gourmet_burger, //R110
            Vegans_burger, //R100
            add_Chips //R15
        }

        //Edwin - pizza
        enum pizza
        {
            back,
            Meaty_pizza, //R90
            chicken_pizza, //95
            vegetarian_pizza, //R110
            Greek_Pizza, //R100
            Margherita_pizza, //R85
            seafood_pizza, //R150
            pepperoni_pizza, //R75
            cheese_pizza, //R60
            hawaiian_pizza //R65
        }

        //Frank - drinks
        enum drinks
        {
            back,
            Coke /*15*/,
            Sprite/*12*/,
            Cream_Soda/*10*/,
            Pepsi/*13*/,
            Lemon_Twist/*14*/,
            Granadilla_Twist/*14*/,
            Iron_Brew/*11*/,
            Mountain_Dew/*12*/,
            Banana_Milkshake/*25*/,
            Strawberry_Milkshake/*22*/,
            Chocolate_Milkshake/*25*/
        }

        //Justin - wraps
        enum wraps
        {
            back,
            Beef_wrap,//55
            Chicken_wrap,//50
            Bacon_avo_and_feta_wrap,//80
            Cheesy_chilly_beef_wrap,//65
            Vegan_wrap, // 65
            Mediteranian_wrap,//85
        }
    }
}