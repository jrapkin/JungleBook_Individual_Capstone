﻿using JungleBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JungleBook.Contracts
{
	public interface IDestinationRepository : IRepositoryBase<Destination>
	{
		void CreateDestination(Destination destination);
	}
}
