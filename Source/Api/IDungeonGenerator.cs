﻿using Entropy;
using Entropy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Tuples;
using Turnable.Characters;
using Turnable.Components;
using Turnable.LevelGenerators;
using Turnable.Locations;

namespace Turnable.Api
{
    public interface IDungeonGenerator
    {
        // ----------------
        // Public interface
        // ----------------

        // Methods
        Level Generate();

        // Properties

        // Events

        // -----------------
        // Private interface
        // -----------------

        // Methods
        List<Chunk> Chunkify(Chunk initialChunk);
        List<Room> PlaceRooms(List<Chunk> chunks);
        List<Corridor> JoinRooms(List<Room> rooms);

        // Properties

        // Events

    }
}