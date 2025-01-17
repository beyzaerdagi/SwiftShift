﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Bitirme.Models;
using Microsoft.AspNetCore.Identity;

namespace Bitirme.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public ApplicationUser()
    {
        Messages = new HashSet<Message>();
    }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int ConfirmCode { get; set; }
    public byte[]? ProfilePicture { get; set; }

    public decimal? Point { get; set; }

    public string? ProfileDescription { get; set; }

    public string? AdvertNumber { get; set; }

    public string? DeliverNumber { get; set; }

    public string? TransportNumber { get; set; }

    [Required]
    [ForeignKey("Country")]
    [DisplayName("Country")]
    public int CountryId { get; set; }
    public virtual Country Country { get; set; }

    [Required]
    [ForeignKey("City")]
    [DisplayName("City")]
    public int CityId { get; set; }
    public virtual City City { get; set; }

    [Required]
    [ForeignKey("District")]
    [DisplayName("District")]
    public int DistrictId { get; set; }
    public virtual District District { get; set; }

    public string Latitude { get; set; }
    public string Longitude { get; set; }

    public virtual ICollection<Message> Messages { get; set; }

    [Range(0, 10)]
    public int TotalRating { get; set; } // Kullanıcının toplam puanı

    public int RatingCount { get; set; } // Kullanıcıya yapılan değerlendirme sayısı

    public ICollection<UserReview> ReviewsReceived { get; set; }

    public string? Address { get; set; }
    public double PaidPrice { get; set; }

    public string UserIBAN { get; set; }
    public string TCKN { get; set; }
    public DateTime BirthDate { get; set; }

    public int isVerified { get; set; }
    public string Gender { get; set; }
    public DateTime RegisterDate { get; set; }


}

