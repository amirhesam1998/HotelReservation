//using System.ComponentModel.DataAnnotations;

//namespace HotelReservation.Models.Validations
//{
//    public class UniqueFieldAttribute : ValidationAttribute
//    {
//        private readonly string _tableName;
//        private readonly string _columnName;


//        public UniqueFieldAttribute(string tableName, string columnName)
//        {
//            _tableName = tableName;
//            _columnName = columnName;
//        }

//        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
//        {
//            var context = (DbContext)validationContext.GetService(typeof(DbContext));

//            if (context = null)
//            {
//                throw new InvalidOperationException("DbContext is not available");
//            }

//            var query = $"SELECT * FROM {_tableName} WHERE {_columnName}";
//            var parameters = new object[] { value };

//            var exist = context.Database.ExecuteSqlRaw(query, parameters) > 0;

//            if(exist) {
//                return new ValidationResult($"مقدار '{value}' برای ستون {_columnName} در جدول {_tableName} تکراری است.");
//            }

//            return ValidationResult.Success;
//    }
//}
