using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text.RegularExpressions;
using APBD_Test_2.DTOs.Requests;

namespace APBD_Test_2.Helpers
{
    public class ValidationHelper
    {
        private const string YEAR_REGEX = @"^\d{4}$";
        private const string NAME_REGEX = "^[A-Z][-a-zA-Z]+$";

        private const string DATE_REGEX =
            @"^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])(2[0-3]|[01][0-9]):[0-5][0-9]:[0-5][0-9]$";


        public static List<Error> ValidateAddPet(AddPetRequest request)
        {
            List<Error> errors = new List<Error>();
            if (IsMaleMatches(request.IsMale))
            {
                errors.Add(new Error
                {
                    Field = "IsMale",
                    InvalidValue = request.IsMale,
                    Message = "ONLY 1 or 2"
                });
            }

            if (DateMatches(request.DateRegistered))
            {
                errors.Add(new Error
                {
                    Field = "DateRegistered",
                    InvalidValue = request.DateRegistered,
                    Message = "WRONG FORMAT"
                });
            }
            
            if (DateMatches(request.ApproximateDateOfBirth))
            {
                errors.Add(new Error
                {
                    Field = "ApproximateDateOfBirth",
                    InvalidValue = request.ApproximateDateOfBirth,
                    Message = "WRONG FORMAT"
                });
            }


            return errors;
        }

        private static bool IsMaleMatches(string requestIsMale)
        {
            return Regex.IsMatch(requestIsMale, "^0|1$");
        }

        public static bool IsYearValid(string year)
        {
            return Regex.IsMatch(year, YEAR_REGEX);
        }

        private static bool DateMatches(string date)
        {
            return Regex.IsMatch(date, DATE_REGEX);
        }
    }
}