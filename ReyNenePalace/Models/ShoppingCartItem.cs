namespace ReyNenePalace.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartITemId { get; set; }
        public Pie Pie { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
