﻿using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
	public interface IUserProfileRepository : IRepositoryBase<UserProfile>
	{
		void CreateUserProfile(Trip trip, Traveler traveler);
		List<Trip> GetAllTripsByTraveler(int travelerId);
		List<Traveler> GetAllTravelersByTrip(int tripId);
		Task<List<Traveler>> GetAllTravelersByTripAsync(int tripId);
		UserProfile GetUserProfileByIds(int travelerId, int tripId);
		Task<UserProfile> GetUserProfileByIdsAsync(int travelerId, int tripId);
		Task<UserProfile> GetUserProfileByInviteCode(string username, string tripName);
		List<Destination> GetAllDestinationsByTravelerId(int travelerId);
	}
}
