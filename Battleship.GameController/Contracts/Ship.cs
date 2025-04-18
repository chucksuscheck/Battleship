﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Battleship.GameController.Contracts
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The ship.
    /// </summary>
    public class Ship
    {
        private bool isPlaced;

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Ship"/> class.
        /// </summary>
        public Ship()
        {
            Positions = new List<Position>();
			Health = new List<Position>();
		}

		#endregion

		#region Public Properties

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the positions.
        /// </summary>
        public List<Position> Positions { get; set; }


		public List<Position> Health { get; set; }

		/// <summary>
		/// The color of the ship
		/// </summary>
		public ConsoleColor Color { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        public int Size { get; set; }

		#endregion

		#region Public Methods and Operators

		/// <summary>
		/// The add position.
		/// </summary>
		/// <param name="input">
		/// The input.
		/// </param>
		public void AddPositionAndHealth(string input)
		{
			var letter = (Letters)Enum.Parse(typeof(Letters), input.ToUpper().Substring(0, 1));
			var number = int.Parse(input.Substring(1, 1));
			var currentPos = new Position { Column = letter, Row = number };
			Positions.Add(currentPos);
			Health.Add(currentPos);
		}

		/// <summary>
		/// If health is below 1, return true else false
		/// </summary>
		/// <returns></returns>
		public bool IsSunk()
		{
			return this.Health.Count < 1;
		}



		public bool IsPlaced
        {
            get { return isPlaced; }
            set
            {
                if (value.Equals(isPlaced)) return;
                isPlaced = value;
            }
        }
        #endregion
    }
}