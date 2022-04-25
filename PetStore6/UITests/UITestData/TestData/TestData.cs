﻿namespace PetStore6.UITests.UITestData.TestData
{
    public class TestDetails
    {
        public string HomePageUrl;
        public string FilmName;
        public string FilmPage;
        public string Login;
        public string Password;
        public double Rating;
        public int WaitTime;
        public string Browser;

        public TestDetails(string homePageUrl, string filmName, string filmPage, string login, string password, double rating, int waitTime, string browser)
        {
            HomePageUrl = homePageUrl;
            FilmName = filmName;
            FilmPage = filmPage;
            Login = login;
            Password = password;
            Rating = rating;
            WaitTime = waitTime;
            Browser = browser;
        }
    }
}
