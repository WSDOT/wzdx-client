﻿using System;
using Wzdx.GeoJson.Geometries;
using Wzdx.v4.Feeds;

namespace Wzdx.v4.Devices
{
    /// <summary>
    /// Provides extensions of v4 IFieldDeviceFeatureBuilderFactory 
    /// </summary>
    public static class DeviceFeatureBuilderFactoryExtensions
    {
        public static ArrowBoardFeatureBuilder ArrowBoard(this IFieldDeviceFeatureBuilderFactory factory, string roadName, Point geometry)
        {
            return new ArrowBoardFeatureBuilder(factory.SourceId, factory.FeatureId, roadName)
                .WithGeometry(geometry);
        }

        public static CameraFeatureBuilder Camera(this IFieldDeviceFeatureBuilderFactory factory, string roadName, Point geometry)
        {
            return new CameraFeatureBuilder(factory.SourceId, factory.FeatureId, roadName)
                .WithGeometry(geometry);
        }

        public static DynamicMessageSignFeatureBuilder DynamicMessageSign(this IFieldDeviceFeatureBuilderFactory factory, string roadName, Point geometry)
        {
            return new DynamicMessageSignFeatureBuilder(factory.SourceId, factory.FeatureId, roadName)
                .WithGeometry(geometry);
        }

        public static FlashingBeaconFeatureBuilder FlashingBeacon(this IFieldDeviceFeatureBuilderFactory factory, string roadName, Point geometry, FlashingBeaconFunction function)
        {
            return new FlashingBeaconFeatureBuilder(factory.SourceId, factory.FeatureId, roadName)
                .WithFunction(function)
                .WithGeometry(geometry);
        }

        public static HybridSignFeatureBuilder HybridSign(this IFieldDeviceFeatureBuilderFactory factory, string roadName, Point geometry,
            HybridSignDynamicMessageFunction function)
        {
            return new HybridSignFeatureBuilder(factory.SourceId, factory.FeatureId, roadName)
                .WithFunction(function)
                .WithGeometry(geometry);
        }

        public static LocationMarkerFeatureBuilder LocationMarker(this IFieldDeviceFeatureBuilderFactory factory,
            string roadName, Point geometry, MarkedLocationType type,
            Func<MarkedLocationBuilder, MarkedLocationBuilder> locationSetup)
        {
            return new LocationMarkerFeatureBuilder(factory.SourceId, factory.FeatureId, roadName)
                .WithMarkedLocation(type, locationSetup)
                .WithGeometry(geometry);
        }

        public static TrafficSensorFeatureBuilder TrafficSensor(this IFieldDeviceFeatureBuilderFactory factory, string roadName, Point geometry)
        {
            return new TrafficSensorFeatureBuilder(factory.SourceId, factory.FeatureId, roadName)
                .WithGeometry(geometry);
        }
    }
}
