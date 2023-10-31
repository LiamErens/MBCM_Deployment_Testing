﻿namespace MBCM_PWA.Client.Shared.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int UserID { get; set; }
        public string userReview { get; set; }
        public int ReviewerID { get; set; }

        // Assuming you want to establish a relationship with tblUser
        public User User { get; set; }
        public User Reviewer { get; set; }
    }
}
