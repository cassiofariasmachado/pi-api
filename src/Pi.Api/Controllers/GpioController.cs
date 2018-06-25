using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Gpio;
using RaspberryPi = Unosquare.RaspberryIO.Pi;

namespace Pi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GpioController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public bool Get(uint id)
        {
            var pin = GetPin(id);
            pin.PinMode = GpioPinDriveMode.Output;
            var isOn = pin.Read();
 
            pin.Write(!isOn);
 
            return !isOn;
        }
 
        private GpioPin GetPin(uint value)
        {
            GpioPin pin;
 
            switch (value)
            {
                case 0:
                    pin = RaspberryPi.Gpio.Pin00;
                    break;
                case 1:
                    pin = RaspberryPi.Gpio.Pin01;
                    break;
                case 2:
                    pin = RaspberryPi.Gpio.Pin02;
                    break;
                case 3:
                    pin = RaspberryPi.Gpio.Pin03;
                    break;
                case 4:
                    pin = RaspberryPi.Gpio.Pin04;
                    break;
                case 5:
                    pin = RaspberryPi.Gpio.Pin05;
                    break;
                case 6:
                    pin = RaspberryPi.Gpio.Pin06;
                    break;
                case 7:
                    pin = RaspberryPi.Gpio.Pin07;
                    break;
                case 8:
                    pin = RaspberryPi.Gpio.Pin08;
                    break;
                case 9:
                    pin = RaspberryPi.Gpio.Pin09;
                    break;
                case 10:
                    pin = RaspberryPi.Gpio.Pin10;
                    break;
                case 11:
                    pin = RaspberryPi.Gpio.Pin11;
                    break;
                case 12:
                    pin = RaspberryPi.Gpio.Pin12;
                    break;
                case 13:
                    pin = RaspberryPi.Gpio.Pin13;
                    break;
                case 14:
                    pin = RaspberryPi.Gpio.Pin14;
                    break;
                case 15:
                    pin = RaspberryPi.Gpio.Pin15;
                    break;
                case 16:
                    pin = RaspberryPi.Gpio.Pin16;
                    break;
                case 17:
                    pin = RaspberryPi.Gpio.Pin17;
                    break;
                case 18:
                    pin = RaspberryPi.Gpio.Pin18;
                    break;
                case 19:
                    pin = RaspberryPi.Gpio.Pin19;
                    break;
                case 20:
                    pin = RaspberryPi.Gpio.Pin20;
                    break;
                case 21:
                    pin = RaspberryPi.Gpio.Pin21;
                    break;
                case 22:
                    pin = RaspberryPi.Gpio.Pin22;
                    break;
                case 23:
                    pin = RaspberryPi.Gpio.Pin23;
                    break;
                case 24:
                    pin = RaspberryPi.Gpio.Pin24;
                    break;
                case 25:
                    pin = RaspberryPi.Gpio.Pin25;
                    break;
                case 26:
                    pin = RaspberryPi.Gpio.Pin26;
                    break;
                case 27:
                    pin = RaspberryPi.Gpio.Pin27;
                    break;
                case 28:
                    pin = RaspberryPi.Gpio.Pin28;
                    break;
                case 29:
                    pin = RaspberryPi.Gpio.Pin29;
                    break;
                case 30:
                    pin = RaspberryPi.Gpio.Pin30;
                    break;
                case 31:
                    pin = RaspberryPi.Gpio.Pin31;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(value), "Value must be between 0 and 31");
            }
 
            return pin;
        }
    }
}
