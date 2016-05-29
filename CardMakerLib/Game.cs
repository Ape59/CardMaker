using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardMakerLib
{
	public class Game
	{
		#region Members
		private CardMaker m_CardMaker = null;
		private Deck m_Deck = null;
		private List<string> m_lstCardIDsGame = null;
		#endregion

		#region Get/Set
		public int StackSize
		{
			get { return m_lstCardIDsGame.Count; }
		}
		#endregion

		#region Constructor
		public Game(CardMaker f_CardMaker, Deck f_Deck)
		{
			m_CardMaker = f_CardMaker;
			m_Deck = f_Deck;

			ResetCards();
		}
		#endregion

		#region ResetCards
		public void ResetCards()
		{
			m_lstCardIDsGame = new List<string>();
			m_lstCardIDsGame.AddRange(m_Deck.CardIDs);

			ShuffleCards();
		}
		#endregion

		#region ShuffleCards
		public void ShuffleCards()
		{
			Random random = null;
			string strCardID = string.Empty;
			int iCount = 0;
			int iRnd = 0;

			random = new Random();
			iCount = m_lstCardIDsGame.Count;

			while(iCount > 1)
			{
				iCount--;
				iRnd = random.Next(iCount + 1);

				strCardID = m_lstCardIDsGame[iRnd];
				m_lstCardIDsGame[iRnd] = m_lstCardIDsGame[iCount];
				m_lstCardIDsGame[iCount] = strCardID;
			}
		}
		#endregion

		#region PickCard
		public Card PickCard()
		{
			Card card = null;
			string strCardID = string.Empty;

			if(m_lstCardIDsGame.Count > 0)
			{
				strCardID = m_lstCardIDsGame[m_lstCardIDsGame.Count - 1];

				foreach(Card c in m_CardMaker.Data.Cards)
				{
					if(c.ID == strCardID)
					{
						card = c;
						break;
					}
				}

				m_lstCardIDsGame.RemoveAt(m_lstCardIDsGame.Count - 1);
			}

			return card;
		}
		#endregion
	}
}
