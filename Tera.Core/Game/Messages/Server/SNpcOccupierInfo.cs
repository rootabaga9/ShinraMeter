﻿using System;

namespace Tera.Game.Messages
{
    public class SNpcOccupierInfo : ParsedMessage

    {
        internal SNpcOccupierInfo(TeraMessageReader reader) : base(reader)
        {
            PrintRaw();
            NPC = reader.ReadEntityId();
            reader.Skip(8);
            Target = reader.ReadEntityId();

            Console.WriteLine("NPC:"+NPC+";Target:"+Target);

        }

        public EntityId NPC { get; private set; }
        public EntityId Target { get; private set; }

    }
}