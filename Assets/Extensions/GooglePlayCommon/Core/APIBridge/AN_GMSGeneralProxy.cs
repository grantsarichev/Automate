﻿using UnityEngine;
using System.Collections;

public class AN_GMSGeneralProxy : MonoBehaviour {

	private const string CLASS_NAME = "com.androidnative.gms.core.GameClientBridge";

	private static void CallActivityFunction(string methodName, params object[] args) {
		AN_ProxyPool.CallStatic(CLASS_NAME, methodName, args);
	}

	//--------------------------------------
	// Play Service
	//--------------------------------------

	public static void loadGoogleAccountNames() {
		CallActivityFunction("loadGoogleAccountNames");
	}
	
	public static void clearDefaultAccount() {
		CallActivityFunction("clearDefaultAccount");
	}
	
	
	public static void playServiceInit (string scopes) {
		CallActivityFunction("playServiceInit", scopes);
	}
	
	public static void playServiceConnect() {
		CallActivityFunction("playServiceConnect");
	}
	
	
	public static void playServiceConnect(string accountName) {
		CallActivityFunction("playServiceConnect", accountName);
	}
	
	public static void loadToken(string accountName, string scope) {
		CallActivityFunction("getToken", accountName, scope);
	}
	
	public static void loadToken() {
		CallActivityFunction("getToken");
	}
	
	public static void invalidateToken(string token) {
		CallActivityFunction("invalidateToken", token);
	}
	
	
	public static void playServiceDisconnect() {
		CallActivityFunction("playServiceDisconnect");
	}
	
	public static void showAchivmentsUI() {
		CallActivityFunction("showAchivments");
	}
	
	public static void showLeaderBoardsUI() {
		CallActivityFunction("showLeaderBoards");
	}
	
	public static void loadConnectedPlayers() {
		CallActivityFunction("loadConnectedPlayers");
	}
	
	
	public static void showLeaderBoard(string leaderboardName) {
		CallActivityFunction("showLeaderBoard", leaderboardName);
	}
	
	public static void showLeaderBoardById(string leaderboardId) {
		CallActivityFunction("showLeaderBoardById", leaderboardId);
	}
	
	
	public static void submitScore(string leaderboardName, long score) {
		CallActivityFunction("submitScore", leaderboardName, score.ToString());
	}
	
	public static void submitScoreById(string leaderboardId, long score) {
		CallActivityFunction("submitScoreById", leaderboardId, score.ToString());
	}
	
	public static void loadLeaderBoards() {
		CallActivityFunction("loadLeaderBoards");
	}
	
	
	public static void UpdatePlayerScore(string leaderboardId, int span, int leaderboardCollection) {
		CallActivityFunction("updatePlayerScore", leaderboardId, span.ToString(), leaderboardCollection.ToString());
	}
	
	
	public static void loadPlayerCenteredScores(string leaderboardId, int span, int leaderboardCollection, int maxResults) {
		CallActivityFunction("loadPlayerCenteredScores", leaderboardId, span.ToString(), leaderboardCollection.ToString(), maxResults.ToString());
	}
	
	public static void loadTopScores(string leaderboardId, int span, int leaderboardCollection, int maxResults) {
		CallActivityFunction("loadTopScores", leaderboardId, span.ToString(), leaderboardCollection.ToString(), maxResults.ToString());
	}
	
	public static void reportAchievement(string achievementName) {
		CallActivityFunction("reportAchievement", achievementName);
	}
	
	public static void reportAchievementById(string achievementId) {
		CallActivityFunction("reportAchievementById", achievementId);
	}
	
	
	public static void revealAchievement(string achievementName) {
		CallActivityFunction("revealAchievement", achievementName);
	}
	
	public static void revealAchievementById(string achievementId) {
		CallActivityFunction("revealAchievementById", achievementId);
	}
	
	public static void incrementAchievement(string achievementName, string numsteps) {
		CallActivityFunction("incrementAchievement", achievementName, numsteps);
	}
	
	public static void incrementAchievementById(string achievementId, string numsteps) {
		CallActivityFunction("incrementAchievementById", achievementId, numsteps);
	}
	
	public static void loadAchievements() {
		CallActivityFunction("loadAchievements");
	}
	
	
	public static void resetAchievement(string achievementId) {
		CallActivityFunction("resetAchievement", achievementId);
	}
	
	public static void ResetAllAchievements() {
		CallActivityFunction("resetAllAchievements");
	}
	
	
	public static void resetLeaderBoard(string leaderboardId) {
		CallActivityFunction("resetLeaderBoard", leaderboardId);
	}
}
