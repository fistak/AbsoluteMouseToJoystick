﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteMouseToJoystick.Data
{
    // TODO: save/load from/to file
    public class Settings : ObservableObject
    {
        public Settings(ISimpleLogger logger)
        {
            _logger = logger;
        }

        private readonly ISimpleLogger _logger;

        public int ResolutionX
        {
            get => _resolutionX;
            set
            {
                Set(ref _resolutionX, value);
                _logger.Log("Resolution X changed");
            }
        }
        public int ResolutionY
        {
            get => _resolutionY;
            set
            {
                Set(ref _resolutionY, value);
                _logger.Log("Resolution Y changed");
            }
        }

        public double TimerInterval
        {
            get => _timerInterval;
            set
            {
                Set(ref _timerInterval, value);
                _logger.Log("Timer interval changed");
            }
        }

        public uint DeviceID
        {
            get => _deviceID;
            set
            {
                Set(ref _deviceID, value);
                _logger.Log("Device ID changed");
            }
        }

        public ZoneDistribution ZoneDistributionX
        {
            get => _zoneDistributionX;
            set
            {
                Set(ref _zoneDistributionX, value);
                _logger.Log("Zone distribution X changed");
            }
        }
        public ZoneDistribution ZoneDistributionY
        {
            get => _zoneDistributionY;
            set
            {
                Set(ref _zoneDistributionY, value);
                _logger.Log("Zone Distribution Y changed");
            }
        }

        private int _resolutionX = 1920;
        private int _resolutionY = 1080;
        private double _timerInterval = 5;
        private uint _deviceID = 1;

        public ZoneDistribution _zoneDistributionX = new ZoneDistribution
        {
            NegativeDeadZone = 1,
            NegativeZone = 100,
            NeutralDeadZone = 0,
            PositiveZone = 100,
            PositiveDeadZone = 1,
        };
        private ZoneDistribution _zoneDistributionY = new ZoneDistribution
        {
            NegativeDeadZone = 1,
            NegativeZone = 12,
            NeutralDeadZone = 2,
            PositiveZone = 8,
            PositiveDeadZone = 3,
        };
    }
}