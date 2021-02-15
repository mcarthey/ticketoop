﻿using System;

namespace TicketOOP.Models
{
    public class Ticket : IEquatable<Ticket>, IComparable<Ticket>
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
        }

        public bool Equals(Ticket other)
        {
            return Name == other.Name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Ticket) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Id.GetHashCode() * 397) ^ Name.GetHashCode();
            }
        }

        int IComparable<Ticket>.CompareTo(Ticket other)
        {
            throw new NotImplementedException();
        }
    }
}
