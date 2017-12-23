using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Identity;

namespace IdentitySample.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [UserClaim("given_name")]
        public string FirstName { get; set; }

        [UserClaim("family_name")]
        public string LastName { get; set; }

        [UserClaim("picture")]
        public string AvatarUrl { get; set; }

        [UserClaim("birth_date")]
        public DateTimeOffset Birthdate { get; set; }

        [UserClaim("phone_number")]
        public string Telephone { get; set; }

        public Address Address { get; set; } = new Address();
    }

    public class Address
    {
        [UserClaim("street_address")]
        public string Street { get; set; }

        [UserClaim("postal_code")]
        public string ZipCode { get; set; }

        [UserClaim("locality")]
        public string City { get; set; }

        [UserClaim("region")]
        public string State { get; set; }

        [UserClaim]
        public string Country { get; set; }
    }
}
