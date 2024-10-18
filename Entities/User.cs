using System.ComponentModel.DataAnnotations;

namespace desafio_criptografia.Entities
{
    public class User
    {
        
        public int Id { get; set; }
        public string? UserDocument { get; set; }
        public string? CreditCardToken { get; set; }
        public double? Value { get; set; }
    }
}
