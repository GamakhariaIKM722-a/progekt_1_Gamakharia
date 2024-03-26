using progekt_1_Gamakharia;
var Product = new Product("beverage","milk",3,7,5);
Product.Productinfo();
Product.change_of_today_is_date(7);

if (Product.shelf_life_expired()) {
    Console.WriteLine("shelf life expired");
}
else
{
    Console.WriteLine("the product is edible");

}