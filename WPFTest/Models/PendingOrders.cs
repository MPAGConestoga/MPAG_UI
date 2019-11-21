using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest.Models
{
    public class PendingOrders : ObservableObject
    {
        private int orderID;
        public int OrderID
        {
            get { return orderID; }
            set { OnPropertyChanged(ref orderID, value);  }
        }

        private string customer;
        public string Customer
        {
            get { return customer; }
            set { OnPropertyChanged(ref customer, value); }
        }

        private JobType jobType;
        public JobType JobType
        {
            get { return jobType; }
            set { OnPropertyChanged(ref jobType, value); }
        }

        private string origin;
        public string Origin
        {
            get { return origin; }
            set { OnPropertyChanged(ref origin, value); }
        }

        private string destination;
        public string Destination
        {
            get { return destination; }
            set { OnPropertyChanged(ref destination, value); }
        }

        private VanType vanType;
        public VanType VanType
        {
            get { return vanType; }
            set { OnPropertyChanged(ref vanType, value); }
        }

        private int attachedCarriers;
        public int AttachedCarriers
        {
            get { return attachedCarriers; }
            set { OnPropertyChanged(ref attachedCarriers, value); }
        }

        public static ObservableCollection<PendingOrders> GetPending()
        {
            var pendingColl = new ObservableCollection<PendingOrders>();
            pendingColl.Add(new PendingOrders() { OrderID = 001, Customer = "Jev Robotics", JobType = JobType.FTL, Origin = "London", Destination = "Toronto", VanType = VanType.Dry, AttachedCarriers = 0 });
            pendingColl.Add(new PendingOrders() { OrderID = 002, Customer = "Ishmail's Fish", JobType = JobType.LTL, Origin = "Windsor", Destination = "London", VanType = VanType.Reefer, AttachedCarriers = 0 });
            pendingColl.Add(new PendingOrders() { OrderID = 003, Customer = "Cats", JobType = JobType.FTL, Origin = "Toronto", Destination = "Kingston", VanType = VanType.Dry, AttachedCarriers = 0 });
            pendingColl.Add(new PendingOrders() { OrderID = 004, Customer = "Ice Sculptors United", JobType = JobType.LTL, Origin = "Belleville", Destination = "Ottawa", VanType = VanType.Dry, AttachedCarriers = 0 });
            pendingColl.Add(new PendingOrders() { OrderID = 005, Customer = "Factory Shoe", JobType = JobType.FTL, Origin = "Kingston", Destination = "Hamilton", VanType = VanType.Dry, AttachedCarriers = 0 });

            return pendingColl;
        }
    }

    public enum VanType
    {
        Dry,
        Reefer
    }

    public enum JobType
    {
        FTL,
        LTL
    }
}
