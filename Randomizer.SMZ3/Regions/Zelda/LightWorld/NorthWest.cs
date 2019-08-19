﻿using System.Collections.Generic;
using static Randomizer.SMZ3.RewardType;

namespace Randomizer.SMZ3.Regions.Zelda.LightWorld {

    class NorthWest : Z3Region {

        public override string Name => "Light World North West";
        public override string Area => "Light World";

        public NorthWest(World world, Config config) : base(world, config) {
            var sphereOne = -14;
            Locations = new List<Location> {
                new Location(this, 256+14, 0x289B0, LocationType.Pedestal, "Master Sword Pedestal",
                    items => World.CanAquireAll(items, PendantGreen, PendantNonGreen)),
                new Location(this, 256+15, 0x180013, LocationType.Regular, "Mushroom").Weighted(sphereOne),
                new Location(this, 256+16, 0x180000, LocationType.Regular, "Lost Woods Hideout").Weighted(sphereOne),
                new Location(this, 256+17, 0x180001, LocationType.Regular, "Lumberjack Tree",
                    items => World.CanAquire(items, Agahnim) && items.Boots),
                new Location(this, 256+18, 0xEB3F, LocationType.Regular, "Pegasus Rocks",
                    items => items.Boots),
                new Location(this, 256+19, 0x180004, LocationType.Regular, "Graveyard Ledge",
                    items => items.Mirror && items.MoonPearl && World.CanEnter("Dark World North West", items)),
                new Location(this, 256+20, 0xE97A, LocationType.Regular, "King's Tomb",
                    items => items.Boots && (
                        items.CanLiftHeavy() ||
                        items.Mirror && items.MoonPearl && World.CanEnter("Dark World North West", items))),
                new Location(this, 256+21, 0xEA8E, LocationType.Regular, "Kakariko Well - Top").Weighted(sphereOne),
                new Location(this, 256+22, 0xEA91, LocationType.Regular, "Kakariko Well - Left").Weighted(sphereOne),
                new Location(this, 256+23, 0xEA94, LocationType.Regular, "Kakariko Well - Middle").Weighted(sphereOne),
                new Location(this, 256+24, 0xEA97, LocationType.Regular, "Kakariko Well - Right").Weighted(sphereOne),
                new Location(this, 256+25, 0xEA9A, LocationType.Regular, "Kakariko Well - Bottom").Weighted(sphereOne),
                new Location(this, 256+26, 0xEB0F, LocationType.Regular, "Blind's Hideout - Top").Weighted(sphereOne),
                new Location(this, 256+27, 0xEB18, LocationType.Regular, "Blind's Hideout - Far Left").Weighted(sphereOne),
                new Location(this, 256+28, 0xEB12, LocationType.Regular, "Blind's Hideout - Left").Weighted(sphereOne),
                new Location(this, 256+29, 0xEB15, LocationType.Regular, "Blind's Hideout - Right").Weighted(sphereOne),
                new Location(this, 256+30, 0xEB1B, LocationType.Regular, "Blind's Hideout - Far Right").Weighted(sphereOne),
                new Location(this, 256+31, 0x2EB18, LocationType.Regular, "Bottle Merchant").Weighted(sphereOne),
                new Location(this, 256+250, 0xE9E9, LocationType.Regular, "Chicken House").Weighted(sphereOne),
                new Location(this, 256+33, 0x339CF, LocationType.Regular, "Sick Kid",
                    items => items.Bottle),
                new Location(this, 256+34, 0xE9CE, LocationType.Regular, "Kakariko Tavern").Weighted(sphereOne),
                new Location(this, 256+35, 0x180015, LocationType.Regular, "Magic Bat",
                    items => items.Powder && (items.Hammer || items.MoonPearl && items.Mirror && items.CanLiftHeavy())),
            };
        }

    }

}
