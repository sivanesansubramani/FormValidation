using FormValidation.Models;

namespace FormValidation.Repository
{
    public class LocationRepository
    {

        public readonly string connectionString;

        public LocationRepository()
        {
            connectionString = @"Data source=DESKTOP-531QTCP;Initial catalog=batch6;User Id=sa;Password=Anaiyaan@123";
        }


        public List<LocationModel> GetAllLocation()
        {
            var result = new List<LocationModel>();

            //Adding the First Location
            var firstRecord = new LocationModel();
            firstRecord.Id = 1;
            firstRecord.Name = "Palani";
            firstRecord.Description = "Temple Down";
            firstRecord.IsActive = true;

            result.Add(firstRecord);
            //Adding the Second Location
            firstRecord = new LocationModel();
            firstRecord.Id = 2;
            firstRecord.Name = "Thoppampatti";
            firstRecord.Description = "Market";
            firstRecord.IsActive = true;


            result.Add(firstRecord);

            return result;
        }

    }
}
