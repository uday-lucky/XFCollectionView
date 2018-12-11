using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XFCollectionView.ViewModel
{
    
    public class HomePageViewModel
    {
        public ObservableCollection<UserDetails> userdetails { get; set; }
        public HomePageViewModel()
        {
            userdetails = new ObservableCollection<UserDetails>();
            userdetails.Add(new UserDetails { CityName="Hyderabad",State="Telangana",UserName="Uday",ImageUrl= "https://www.petful.com/wp-content/uploads/2010/03/tips-puppy-house-training.jpg" });
            userdetails.Add(new UserDetails { CityName = "Hyderabad", State = "Telangana", UserName = "Uday" , ImageUrl = "https://www.petful.com/wp-content/uploads/2010/03/tips-puppy-house-training.jpg" });
            userdetails.Add(new UserDetails { CityName = "Bangalore", State = "Karnataka", UserName = "Vidya" , ImageUrl = "https://www.petful.com/wp-content/uploads/2010/03/tips-puppy-house-training.jpg" });
            userdetails.Add(new UserDetails { CityName = "Chennai", State = "Tamilnadu", UserName = "Naresh", ImageUrl = "https://www.petful.com/wp-content/uploads/2010/03/tips-puppy-house-training.jpg" });
            userdetails.Add(new UserDetails { CityName = "patna", State = "Bihar", UserName = "Jacob" , ImageUrl = "https://www.petful.com/wp-content/uploads/2010/03/tips-puppy-house-training.jpg" });
            userdetails.Add(new UserDetails { CityName = "mumbai", State = "Maharastra", UserName = "Ayub" , ImageUrl = "https://www.petful.com/wp-content/uploads/2010/03/tips-puppy-house-training.jpg" });
            userdetails.Add(new UserDetails { CityName = "Hyderabad", State = "Telangana", UserName = "nazia", ImageUrl = "https://www.petful.com/wp-content/uploads/2010/03/tips-puppy-house-training.jpg" });
            userdetails.Add(new UserDetails { CityName = "Bangalore", State = "karnataka", UserName = "dixit", ImageUrl = "https://www.petful.com/wp-content/uploads/2010/03/tips-puppy-house-training.jpg" });
            userdetails.Add(new UserDetails { CityName = "Hyderabad", State = "Telangana", UserName = "Uday", ImageUrl = "https://www.petful.com/wp-content/uploads/2010/03/tips-puppy-house-training.jpg" });
            userdetails.Add(new UserDetails { CityName = "Hyderabad", State = "Telangana", UserName = "Uday", ImageUrl = "https://www.petful.com/wp-content/uploads/2010/03/tips-puppy-house-training.jpg" });
            userdetails.Add(new UserDetails { CityName = "Bangalore", State = "Karnataka", UserName = "Vidya", ImageUrl = "https://www.petful.com/wp-content/uploads/2010/03/tips-puppy-house-training.jpg" });
            userdetails.Add(new UserDetails { CityName = "Chennai", State = "Tamilnadu", UserName = "Naresh" , ImageUrl = "https://www.petful.com/wp-content/uploads/2010/03/tips-puppy-house-training.jpg" });
            userdetails.Add(new UserDetails { CityName = "patna", State = "Bihar", UserName = "Jacob", ImageUrl = "https://www.petful.com/wp-content/uploads/2010/03/tips-puppy-house-training.jpg" });
            userdetails.Add(new UserDetails { CityName = "mumbai", State = "Maharastra", UserName = "Ayub" , ImageUrl = "https://www.petful.com/wp-content/uploads/2010/03/tips-puppy-house-training.jpg" });
            userdetails.Add(new UserDetails { CityName = "Hyderabad", State = "Telangana", UserName = "nazia", ImageUrl = "https://www.petful.com/wp-content/uploads/2010/03/tips-puppy-house-training.jpg" });
            userdetails.Add(new UserDetails { CityName = "Bangalore", State = "karnataka", UserName = "dixit", ImageUrl = "https://www.petful.com/wp-content/uploads/2010/03/tips-puppy-house-training.jpg" });

        }

    }

    public class UserDetails
    {
        public string UserName { get; set; }
        public string CityName { get; set; }
        public string State { get; set; }
        public string ImageUrl { get; set; }
    }

}
