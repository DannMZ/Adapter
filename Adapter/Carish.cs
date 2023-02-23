using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface ITransport
    {
        double speed { get; set; }
        bool Is_There_Wheels { get; set; }
        bool Is_There_Wings { get; set; }
        string Do_Smth();
        string Get_Info();
    }

    public class Bicycle
    {
        public int kilometers_per_hour { get; private set; }
        public Bicycle()
        {
            kilometers_per_hour = 25;
            Is_There_Wheels = true;
            Is_There_Wings = false;
        }
        public bool Is_There_Wings { get; private set; }
        public bool Is_There_Wheels { get; private set; }

        public string Pedal()
        {
            return"Bicycle is pedaling";
        }
    }
    public class ToBicycle : ITransport
    {
        public ToBicycle(Bicycle To)
        {
            Bike=To;
            speed =(double) To.kilometers_per_hour;
            Is_There_Wheels = To.Is_There_Wheels;
            Is_There_Wings = To.Is_There_Wings;
        }
        Bicycle Bike;
        public double speed { get; set; }
        public bool Is_There_Wheels { get; set; }
        public bool Is_There_Wings { get; set; }
        public string Do_Smth()
        {
            return Bike.Pedal();
        }
        public string Get_Info()
        {
            string Info = "It's Bicycle\nSpeed: " + speed.ToString() + "km/h";
            if (Is_There_Wheels) { Info += "\nIt has wheels"; } else { Info += "\nIt has no wheels"; }
            if (Is_There_Wings) { Info += "\nIt has wings"; } else { Info += "\nIt has no wings"; }
            return Info;
        }
    }
    public class Boat
    {
        public int nodes { get; private set; }
        public Boat()
        {
            nodes = 18;
            Is_There_Wheels = false;
            Is_There_Wings = false;
        }
        public bool Is_There_Wings { get; private set; }
        public bool Is_There_Wheels { get; private set; }

        public string Swim()
        {
            return "The boat is sailing";
        }
    }
    public class ToBoat : ITransport
    {
        public ToBoat(Boat To)
        {
            My_Boat = To;
            speed = To.nodes * 1.852;
            Is_There_Wheels = To.Is_There_Wheels;
            Is_There_Wings = To.Is_There_Wings;
        }
        Boat My_Boat;
        public double speed { get; set; }
        public bool Is_There_Wheels { get; set; }
        public bool Is_There_Wings { get; set; }
        public string Do_Smth()
        {
            return My_Boat.Swim();
        }
        public string Get_Info()
        {
            string Info = "It's Boat\nSpeed: " + speed.ToString()+"km/h";
            if (Is_There_Wheels) { Info += "\nIt has wheels"; } else { Info += "\nIt has no wheels"; }
            if (Is_There_Wings) { Info += "\nIt has wings"; } else { Info += "\nIt has no wings"; }
            return Info;
        }
    }
    public class Giant_Slime
    {
        public string blob { get; private set; }
        public Giant_Slime()
        {
            blob = "blob";
            Is_There_Wheels = false;
            Is_There_Wings = true;
        }
        public bool Is_There_Wings { get; private set; }
        public bool Is_There_Wheels { get; private set; }

        public string Blob()
        {
            return "Slime babbled";
        }
    }
    public class ToBlob : ITransport
    {
        public ToBlob(Giant_Slime To)
        {
            Blob = To;
            speed = 20;
            Is_There_Wheels = To.Is_There_Wheels;
            Is_There_Wings = To.Is_There_Wings;
        }
        Giant_Slime Blob;
        public double speed { get; set; }
        public bool Is_There_Wheels { get; set; }
        public bool Is_There_Wings { get; set; }
        public string Do_Smth()
        {
            return Blob.Blob();
        }
        public string Get_Info()
        {
            string Info = "It's Slime\t\t*blob*\t\nSpeed: " + speed.ToString() + "km/ms"+
                "\n*but it will not verify";
            if (Is_There_Wheels) { Info += "\nIt has \t\t*blob*\t wheels"; } else { Info += "\nIt \t\t*blob*\t has no wheels"; }
            if (Is_There_Wings) { Info += "\n\t*blob*\t\tIt has wings"; } else { Info += "\nIt has no \t\t*blob*\twings"; }
            return Info;
        }
    }
    public class Skate
    {
        public double meters_per_minute { get; private set; }
        public Skate()
        {
            meters_per_minute = 75.34;
            Is_There_Wheels = true;
            Is_There_Wings = false;
        }
        public bool Is_There_Wings { get; private set; }
        public bool Is_There_Wheels { get; private set; }

        public string Skate_()
        {
            return "Skating is happening";
        }
    }
    public class ToSkate : ITransport
    {
        public ToSkate(Skate To)
        {
            _Skate = To;
            speed = 20;
            Is_There_Wheels = To.Is_There_Wheels;
            Is_There_Wings = To.Is_There_Wings;
        }
        Skate _Skate;
        public double speed { get; set; }
        public bool Is_There_Wheels { get; set; }
        public bool Is_There_Wings { get; set; }
        public string Do_Smth()
        {
            return _Skate.Skate_();
        }
        public string Get_Info()
        {
            string Info = "It's Skate\nSpeed: " + speed.ToString() + "km/ms";
            if (Is_There_Wheels) { Info += "\nIt has wheels"; } else { Info += "\nIt has no wheels"; }
            if (Is_There_Wings) { Info += "\nIt has wings"; } else { Info += "\nIt has no wings"; }
            return Info;
        }
    }
    public class Change_Transport
    {
        public Change_Transport() { }
        ITransport transport;
        public void set_transport(ITransport transport)
        {
            this.transport = transport;
        }
        public string UseTransport()
        {
          return transport.Do_Smth();
        }
        public string Get_info()
        {
            return transport.Get_Info();
        }
    }

}
