namespace HotelReservation.Models
{
    public class ErrorMessage
    {
        public const string RequiredMsg = "{0} را وادر نمایید";
        public const string MaxLenghtMsg = "{0} نباید بیشتر از {1} کاراکتر باشد";
        public const string MinLenghtMsg = "{0} نباید کمتر از {1} کاراکتر باشد";
        public const string RegExpMsg = "قالب نوشتاری {0} اشتباه است";
        public const string Compare = "{0} وارد شده یکسان نمی باشد";
        public const string StringLength = "باید حداقل 6 کاراکتر و حداکثر 100 کاراکتر باشد {0}{1}";
        public const string Range = "{0} باید بین {1} و {2} باشد";

    }
}
