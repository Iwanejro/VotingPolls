﻿using VotingPolls.Data;

namespace VotingPolls.Models
{
    public class VoteVM
    {
        public VotingPoll VotingPoll { get; set; }
        public int Id { get; set; }                 //Voting Poll Id
        public string UserId { get; set; }          // User that votes
        public int UserAnswer { get; set; }         // radio button answer
        public List<int> UserAnswers { get; set; }  // checkbox answers
    }
}

