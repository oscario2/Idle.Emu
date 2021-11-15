
using System;
using Idle.Emu.Messages.Logic.Protos;
using Idle.Emu.Messages.Login.Protos;

namespace Idle.Emu.Messages 
{
    public static class PacketEvent 
    {
        public static Type Type(EPacketEvent evt) 
        {
            switch(evt) 
            {
                case EPacketEvent.IdleEchoRequest: return typeof(IdleReqEcho);
				case EPacketEvent.IdleEchoResponse: return typeof(IdleRspEcho);
				

				case EPacketEvent.IdlePubRequest: return typeof(IdleReqPub);
				case EPacketEvent.IdlePubResponse: return typeof(IdleRspPub);
				

				case EPacketEvent.IdleRegRequest: return typeof(IdleReqReg);
				case EPacketEvent.IdleRegResponse: return typeof(IdleRspReg);
				

				case EPacketEvent.IdleSaltRequest: return typeof(IdleReqSalt);
				case EPacketEvent.IdleSaltResponse: return typeof(IdleRspSalt);
				

				case EPacketEvent.IdleLoginRequest: return typeof(IdleReqLogin);
				case EPacketEvent.IdleLoginResponse: return typeof(IdleRspLogin);
				

				case EPacketEvent.IdleThirdloginRequest: return typeof(IdleReqThirdlogin);
				case EPacketEvent.IdleThirdloginResponse: return typeof(IdleRspThirdlogin);
				

				case EPacketEvent.IdleServersLoginRequest: return typeof(IdleReqServersLogin);
				case EPacketEvent.IdleServersLoginResponse: return typeof(IdleRspServersLogin);
				

				case EPacketEvent.IdleAuthRequest: return typeof(IdleReqAuth);
				case EPacketEvent.IdleAuthResponse: return typeof(IdleRspAuth);
				

				case EPacketEvent.IdleSyncRequest: return typeof(IdleReqSync);
				case EPacketEvent.IdleSyncResponse: return typeof(IdleRspSync);
				

				case EPacketEvent.IdleUpRequest: return typeof(IdleReqUp);
				case EPacketEvent.IdleUpResponse: return typeof(IdleRspUp);
				

				case EPacketEvent.IdleBindRequest: return typeof(IdleReqBind);
				case EPacketEvent.IdleBindResponse: return typeof(IdleRspBind);
				

				case EPacketEvent.IdleChangePasswordRequest: return typeof(IdleReqChangePassword);
				case EPacketEvent.IdleChangePasswordResponse: return typeof(IdleRspChangePassword);
				

				case EPacketEvent.IdleServersRequest: return typeof(IdleReqServers);
				case EPacketEvent.IdleServersResponse: return typeof(IdleRspServers);
				

				case EPacketEvent.IdlePlayerRequest: return typeof(IdleReqPlayer);
				case EPacketEvent.IdlePlayerResponse: return typeof(IdleRspPlayer);
				

				case EPacketEvent.IdleChangeNameRequest: return typeof(IdleReqChangeName);
				case EPacketEvent.IdleChangeNameResponse: return typeof(IdleRspChangeName);
				

				case EPacketEvent.IdleChangeLogoRequest: return typeof(IdleReqChangeLogo);
				case EPacketEvent.IdleChangeLogoResponse: return typeof(IdleRspChangeLogo);
				

				case EPacketEvent.IdleRateUsRequest: return typeof(IdleReqRateUs);
				case EPacketEvent.IdleRateUsResponse: return typeof(IdleRspRateUs);
				

				case EPacketEvent.IdleCdkeyRequest: return typeof(IdleReqCdkey);
				case EPacketEvent.IdleCdkeyResponse: return typeof(IdleRspCdkey);
				

				case EPacketEvent.IdleLpubRequest: return typeof(IdleReqLpub);
				case EPacketEvent.IdleLpubResponse: return typeof(IdleRspLpub);
				

				case EPacketEvent.IdleChangeBorderRequest: return typeof(IdleReqChangeHeadBorder);
				case EPacketEvent.IdleChangeBorderResponse: return typeof(IdleRspChangeHeadBorder);
				

				case EPacketEvent.IdleUpgradeBorderRequest: return typeof(IdleReqUpgradeHeadBorder);
				case EPacketEvent.IdleUpgradeBorderResponse: return typeof(IdleRspUpgradeHeadBorder);
				

				case EPacketEvent.IdleFlagWebgameRequest: return typeof(IdleReqFlagWebgame);
				case EPacketEvent.IdleFlagWebgameResponse: return typeof(IdleRspFlagWebgame);
				

				case EPacketEvent.IdleSmsgRequest: return typeof(IdleReqSmsg);
				case EPacketEvent.IdleSmsgResponse: return typeof(IdleRspSmsg);
				

				case EPacketEvent.IdleAuditRequest: return typeof(IdleReqAudit);
				case EPacketEvent.IdleAuditResponse: return typeof(IdleRspAudit);
				

				case EPacketEvent.IdleGachaRequest: return typeof(IdleReqGacha);
				case EPacketEvent.IdleGachaResponse: return typeof(IdleRspGacha);
				

				case EPacketEvent.IdleWearRequest: return typeof(IdleReqWear);
				case EPacketEvent.IdleWearResponse: return typeof(IdleRspWear);
				

				case EPacketEvent.IdleHeroDecomposeRequest: return typeof(IdleReqHeroDecompose);
				case EPacketEvent.IdleHeroDecomposeResponse: return typeof(IdleRspHeroDecompose);
				

				case EPacketEvent.IdleHeroMergeRequest: return typeof(IdleReqHeroMerge);
				case EPacketEvent.IdleHeroMergeResponse: return typeof(IdleRspHeroMerge);
				

				case EPacketEvent.IdleHeroUpRequest: return typeof(IdleReqHeroUp);
				case EPacketEvent.IdleHeroUpResponse: return typeof(IdleRspHeroUp);
				

				case EPacketEvent.IdleHeroLockRequest: return typeof(IdleReqHeroLock);
				case EPacketEvent.IdleHeroLockResponse: return typeof(IdleRspHeroLock);
				

				case EPacketEvent.IdleHeroMixRequest: return typeof(IdleReqHeroMix);
				case EPacketEvent.IdleHeroMixResponse: return typeof(IdleRspHeroMix);
				

				case EPacketEvent.IdleJadeOnRequest: return typeof(IdleReqJadeOn);
				case EPacketEvent.IdleJadeOnResponse: return typeof(IdleRspJadeOn);
				

				case EPacketEvent.IdleJadeUpRequest: return typeof(IdleReqJadeUp);
				case EPacketEvent.IdleJadeUpResponse: return typeof(IdleRspJadeUp);
				

				case EPacketEvent.IdleJadeChangeRequest: return typeof(IdleReqJadeChange);
				case EPacketEvent.IdleJadeChangeResponse: return typeof(IdleRspJadeChange);
				

				case EPacketEvent.IdleJadeOkRequest: return typeof(IdleReqJadeOk);
				case EPacketEvent.IdleJadeOkResponse: return typeof(IdleRspJadeOk);
				

				case EPacketEvent.IdleBuyHlimitRequest: return typeof(IdleReqBuyHlimit);
				case EPacketEvent.IdleBuyHlimitResponse: return typeof(IdleRspBuyHlimit);
				

				case EPacketEvent.IdleTransformHeroRequest: return typeof(IdleReqTransformHero);
				case EPacketEvent.IdleTransformHeroResponse: return typeof(IdleRspTransformHero);
				

				case EPacketEvent.IdleTransformOkRequest: return typeof(IdleReqTransformOk);
				case EPacketEvent.IdleTransformOkResponse: return typeof(IdleRspTransformOk);
				

				case EPacketEvent.IdleHeroWakeRequest: return typeof(IdleReqHeroWake);
				case EPacketEvent.IdleHeroWakeResponse: return typeof(IdleRspHeroWake);
				

				case EPacketEvent.IdleHeroChangeRequest: return typeof(IdleReqHeroChange);
				case EPacketEvent.IdleHeroChangeResponse: return typeof(IdleRspHeroChange);
				

				case EPacketEvent.IdleHeroSkinMixRequest: return typeof(IdleReqHeroSkinMix);
				case EPacketEvent.IdleHeroSkinMixResponse: return typeof(IdleRspHeroSkinMix);
				

				case EPacketEvent.IdleHeroSkinWearRequest: return typeof(IdleReqHeroSkinWear);
				case EPacketEvent.IdleHeroSkinWearResponse: return typeof(IdleRspHeroSkinWear);
				

				case EPacketEvent.IdleHeroSkinOffRequest: return typeof(IdleReqHeroSkinOff);
				case EPacketEvent.IdleHeroSkinOffResponse: return typeof(IdleRspHeroSkinOff);
				

				case EPacketEvent.IdleShieldChangeRequest: return typeof(IdleReqShieldChange);
				case EPacketEvent.IdleShieldChangeResponse: return typeof(IdleRspShieldChange);
				

				case EPacketEvent.IdleHeroSkinVisitRequest: return typeof(IdleReqHeroSkinVisit);
				case EPacketEvent.IdleHeroSkinVisitResponse: return typeof(IdleRspHeroSkinVisit);
				

				case EPacketEvent.IdleHeroSkinBreakdownRequest: return typeof(IdleReqHeroSkinBreakdown);
				case EPacketEvent.IdleHeroSkinBreakdownResponse: return typeof(IdleRspHeroSkinBreakdown);
				

				case EPacketEvent.IdleHeroTalenRequest: return typeof(IdleReqHeroTalen);
				case EPacketEvent.IdleHeroTalenResponse: return typeof(IdleRspHeroTalen);
				

				case EPacketEvent.IdleHeroTalenopRequest: return typeof(IdleReqHeroTalenop);
				case EPacketEvent.IdleHeroTalenopResponse: return typeof(IdleRspHeroTalenop);
				

				case EPacketEvent.IdleHeroReturnRequest: return typeof(IdleReqHeroReturn);
				case EPacketEvent.IdleHeroReturnResponse: return typeof(IdleRspHeroReturn);
				

				case EPacketEvent.IdleHeroSkinLimitmixRequest: return typeof(IdleReqHeroSkinLimitmix);
				case EPacketEvent.IdleHeroSkinLimitmixResponse: return typeof(IdleRspHeroSkinLimitmix);
				

				case EPacketEvent.IdleHeroSkinUpRequest: return typeof(IdleReqHeroSkinUp);
				case EPacketEvent.IdleHeroSkinUpResponse: return typeof(IdleRspHeroSkinUp);
				

				case EPacketEvent.IdleHeroTicketRequest: return typeof(IdleReqHeroTicket);
				case EPacketEvent.IdleHeroTicketResponse: return typeof(IdleRspHeroTicket);
				

				case EPacketEvent.IdleJadeUnlockRequest: return typeof(IdleReqJadeUnlock);
				case EPacketEvent.IdleJadeUnlockResponse: return typeof(IdleRspJadeUnlock);
				

				case EPacketEvent.IdleJadeUsedRequest: return typeof(IdleReqJadeUsed);
				case EPacketEvent.IdleJadeUsedResponse: return typeof(IdleRspJadeUsed);
				

				case EPacketEvent.IdleAutoLvupRequest: return typeof(IdleReqAutoLvup);
				case EPacketEvent.IdleAutoLvupResponse: return typeof(IdleRspAutoLvup);
				

				case EPacketEvent.IdleOpMailRequest: return typeof(IdleReqOpMail);
				case EPacketEvent.IdleOpMailResponse: return typeof(IdleRspOpMail);
				

				case EPacketEvent.IdleSendMailRequest: return typeof(IdleReqSendMail);
				case EPacketEvent.IdleSendMailResponse: return typeof(IdleRspSendMail);
				

				case EPacketEvent.IdleSellRequest: return typeof(IdleReqSell);
				case EPacketEvent.IdleSellResponse: return typeof(IdleRspSell);
				

				case EPacketEvent.IdleMidasRequest: return typeof(IdleReqMidas);
				case EPacketEvent.IdleMidasResponse: return typeof(IdleRspMidas);
				

				case EPacketEvent.IdleUpTreasureRequest: return typeof(IdleReqUpTreasure);
				case EPacketEvent.IdleUpTreasureResponse: return typeof(IdleRspUpTreasure);
				

				case EPacketEvent.IdleEquipMergeRequest: return typeof(IdleReqEquipMerge);
				case EPacketEvent.IdleEquipMergeResponse: return typeof(IdleRspEquipMerge);
				

				case EPacketEvent.IdleExchangeActRequest: return typeof(IdleReqExchangeAct);
				case EPacketEvent.IdleExchangeActResponse: return typeof(IdleRspExchangeAct);
				

				case EPacketEvent.IdleOpenGiftRequest: return typeof(IdleReqOpenGift);
				case EPacketEvent.IdleOpenGiftResponse: return typeof(IdleRspOpenGift);
				

				case EPacketEvent.IdleDwarfRequest: return typeof(IdleReqDwarf);
				case EPacketEvent.IdleDwarfResponse: return typeof(IdleRspDwarf);
				

				case EPacketEvent.IdleEquipResolveRequest: return typeof(IdleReqEquipResolve);
				case EPacketEvent.IdleEquipResolveResponse: return typeof(IdleRspEquipResolve);
				

				case EPacketEvent.IdleEquipSoulRequest: return typeof(IdleReqEquipSoul);
				case EPacketEvent.IdleEquipSoulResponse: return typeof(IdleRspEquipSoul);
				

				case EPacketEvent.IdleEquipSoulOkRequest: return typeof(IdleReqEquipSoulOk);
				case EPacketEvent.IdleEquipSoulOkResponse: return typeof(IdleRspEquipSoulOk);
				

				case EPacketEvent.IdleEquipSoulSyncRequest: return typeof(IdleReqEquipSoulSync);
				case EPacketEvent.IdleEquipSoulSyncResponse: return typeof(IdleRspEquipSoulSync);
				

				case EPacketEvent.IdleDwarfChangeRequest: return typeof(IdleReqDwarfChange);
				case EPacketEvent.IdleDwarfChangeResponse: return typeof(IdleRspDwarfChange);
				

				case EPacketEvent.IdleSyncChatRequest: return typeof(IdleReqSyncChat);
				case EPacketEvent.IdleSyncChatResponse: return typeof(IdleRspSyncChat);
				

				case EPacketEvent.IdleChatRequest: return typeof(IdleReqChat);
				case EPacketEvent.IdleChatResponse: return typeof(IdleRspChat);
				

				case EPacketEvent.IdleCunitRequest: return typeof(IdleReqCunit);
				case EPacketEvent.IdleCunitResponse: return typeof(IdleRspCunit);
				

				case EPacketEvent.IdleBlockChatRequest: return typeof(IdleReqBlockChat);
				case EPacketEvent.IdleBlockChatResponse: return typeof(IdleRspBlockChat);
				

				case EPacketEvent.IdleHideVipRequest: return typeof(IdleReqHideVip);
				case EPacketEvent.IdleHideVipResponse: return typeof(IdleRspHideVip);
				

				case EPacketEvent.IdleTranslateRequest: return typeof(IdleReqTranslate);
				case EPacketEvent.IdleTranslateResponse: return typeof(IdleRspTranslate);
				

				case EPacketEvent.IdleChatSettingRequest: return typeof(IdleReqChatSetting);
				case EPacketEvent.IdleChatSettingResponse: return typeof(IdleRspChatSetting);
				

				case EPacketEvent.IdleResolveBlockChatRequest: return typeof(IdleReqResolveBlockChat);
				case EPacketEvent.IdleResolveBlockChatResponse: return typeof(IdleRspResolveBlockChat);
				

				case EPacketEvent.IdleGetBlockChatRequest: return typeof(IdleReqGetBlockChat);
				case EPacketEvent.IdleGetBlockChatResponse: return typeof(IdleRspGetBlockChat);
				

				case EPacketEvent.IdleReportRequest: return typeof(IdleReqReport);
				case EPacketEvent.IdleReportResponse: return typeof(IdleRspReport);
				

				case EPacketEvent.IdleBmarketPullRequest: return typeof(IdleReqBmarketPull);
				case EPacketEvent.IdleBmarketPullResponse: return typeof(IdleRspBmarketPull);
				

				case EPacketEvent.IdleBmarketBuyRequest: return typeof(IdleReqBmarketBuy);
				case EPacketEvent.IdleBmarketBuyResponse: return typeof(IdleRspBmarketBuy);
				

				case EPacketEvent.IdleHookInitRequest: return typeof(IdleReqHookInit);
				case EPacketEvent.IdleHookInitResponse: return typeof(IdleRspHookInit);
				

				case EPacketEvent.IdleHookChangeRequest: return typeof(IdleReqHookChange);
				case EPacketEvent.IdleHookChangeResponse: return typeof(IdleRspHookChange);
				

				case EPacketEvent.IdleHookAskRequest: return typeof(IdleReqHookAsk);
				case EPacketEvent.IdleHookAskResponse: return typeof(IdleRspHookAsk);
				

				case EPacketEvent.IdleHookRewardRequest: return typeof(IdleReqHookReward);
				case EPacketEvent.IdleHookRewardResponse: return typeof(IdleRspHookReward);
				

				case EPacketEvent.IdleTestFightRequest: return typeof(IdleReqTestFight);
				case EPacketEvent.IdleTestFightResponse: return typeof(IdleRspTestFight);
				

				case EPacketEvent.IdlePveRequest: return typeof(IdleReqPve);
				case EPacketEvent.IdlePveResponse: return typeof(IdleRspPve);
				

				case EPacketEvent.IdleSyncBraveRequest: return typeof(IdleReqSyncBrave);
				case EPacketEvent.IdleSyncBraveResponse: return typeof(IdleRspSyncBrave);
				

				case EPacketEvent.IdleBraveFightRequest: return typeof(IdleReqBraveFight);
				case EPacketEvent.IdleBraveFightResponse: return typeof(IdleRspBraveFight);
				

				case EPacketEvent.IdleBravePullRequest: return typeof(IdleReqBravePull);
				case EPacketEvent.IdleBravePullResponse: return typeof(IdleRspBravePull);
				

				case EPacketEvent.IdleBraveNodeRequest: return typeof(IdleReqBraveNode);
				case EPacketEvent.IdleBraveNodeResponse: return typeof(IdleRspBraveNode);
				

				case EPacketEvent.IdlePveRankRequest: return typeof(IdleReqPveRank);
				case EPacketEvent.IdlePveRankResponse: return typeof(IdleRspPveRank);
				

				case EPacketEvent.IdleFrdSyncRequest: return typeof(IdleReqFrdSync);
				case EPacketEvent.IdleFrdSyncResponse: return typeof(IdleRspFrdSync);
				

				case EPacketEvent.IdleFrdOpRequest: return typeof(IdleReqFrdOp);
				case EPacketEvent.IdleFrdOpResponse: return typeof(IdleRspFrdOp);
				

				case EPacketEvent.IdleFrdLoveRequest: return typeof(IdleReqFrdLove);
				case EPacketEvent.IdleFrdLoveResponse: return typeof(IdleRspFrdLove);
				

				case EPacketEvent.IdleFrdPkRequest: return typeof(IdleReqFrdPk);
				case EPacketEvent.IdleFrdPkResponse: return typeof(IdleRspFrdPk);
				

				case EPacketEvent.IdleFrdAdviseRequest: return typeof(IdleReqFrdAdvise);
				case EPacketEvent.IdleFrdAdviseResponse: return typeof(IdleRspFrdAdvise);
				

				case EPacketEvent.IdlePullCasinoRequest: return typeof(IdleReqPullCasino);
				case EPacketEvent.IdlePullCasinoResponse: return typeof(IdleRspPullCasino);
				

				case EPacketEvent.IdleCasinoMsgRequest: return typeof(IdleReqCasinoMsg);
				case EPacketEvent.IdleCasinoMsgResponse: return typeof(IdleRspCasinoMsg);
				

				case EPacketEvent.IdleCasinoDrawRequest: return typeof(IdleReqCasinoDraw);
				case EPacketEvent.IdleCasinoDrawResponse: return typeof(IdleRspCasinoDraw);
				

				case EPacketEvent.IdleCasinoBuyRequest: return typeof(IdleReqCasinoBuy);
				case EPacketEvent.IdleCasinoBuyResponse: return typeof(IdleRspCasinoBuy);
				

				case EPacketEvent.IdleLmarketPullRequest: return typeof(IdleReqLmarketPull);
				case EPacketEvent.IdleLmarketPullResponse: return typeof(IdleRspLmarketPull);
				

				case EPacketEvent.IdleLmarketBuyRequest: return typeof(IdleReqLmarketBuy);
				case EPacketEvent.IdleLmarketBuyResponse: return typeof(IdleRspLmarketBuy);
				

				case EPacketEvent.IdleGuildSyncRequest: return typeof(IdleReqGuildSync);
				case EPacketEvent.IdleGuildSyncResponse: return typeof(IdleRspGuildSync);
				

				case EPacketEvent.IdleGuildRankRequest: return typeof(IdleReqGuildRank);
				case EPacketEvent.IdleGuildRankResponse: return typeof(IdleRspGuildRank);
				

				case EPacketEvent.IdleGlogRequest: return typeof(IdleReqGlog);
				case EPacketEvent.IdleGlogResponse: return typeof(IdleRspGlog);
				

				case EPacketEvent.IdleGuildCreateRequest: return typeof(IdleReqGuildCreate);
				case EPacketEvent.IdleGuildCreateResponse: return typeof(IdleRspGuildCreate);
				

				case EPacketEvent.IdleGuildNoticeRequest: return typeof(IdleReqGuildNotice);
				case EPacketEvent.IdleGuildNoticeResponse: return typeof(IdleRspGuildNotice);
				

				case EPacketEvent.IdleGuildFlagRequest: return typeof(IdleReqGuildFlag);
				case EPacketEvent.IdleGuildFlagResponse: return typeof(IdleRspGuildFlag);
				

				case EPacketEvent.IdleGuildNameRequest: return typeof(IdleReqGuildName);
				case EPacketEvent.IdleGuildNameResponse: return typeof(IdleRspGuildName);
				

				case EPacketEvent.IdleGuildDismissRequest: return typeof(IdleReqGuildDismiss);
				case EPacketEvent.IdleGuildDismissResponse: return typeof(IdleRspGuildDismiss);
				

				case EPacketEvent.IdleGuildApplyRequest: return typeof(IdleReqGuildApply);
				case EPacketEvent.IdleGuildApplyResponse: return typeof(IdleRspGuildApply);
				

				case EPacketEvent.IdleGuildLeaveRequest: return typeof(IdleReqGuildLeave);
				case EPacketEvent.IdleGuildLeaveResponse: return typeof(IdleRspGuildLeave);
				

				case EPacketEvent.IdleGuildSignRequest: return typeof(IdleReqGuildSign);
				case EPacketEvent.IdleGuildSignResponse: return typeof(IdleRspGuildSign);
				

				case EPacketEvent.IdleGuildRecommendRequest: return typeof(IdleReqGuildRecommend);
				case EPacketEvent.IdleGuildRecommendResponse: return typeof(IdleRspGuildRecommend);
				

				case EPacketEvent.IdleGuildSearchRequest: return typeof(IdleReqGuildSearch);
				case EPacketEvent.IdleGuildSearchResponse: return typeof(IdleRspGuildSearch);
				

				case EPacketEvent.IdleGuildAppliersRequest: return typeof(IdleReqGuildAppliers);
				case EPacketEvent.IdleGuildAppliersResponse: return typeof(IdleRspGuildAppliers);
				

				case EPacketEvent.IdleGmemberOptRequest: return typeof(IdleReqGmemberOpt);
				case EPacketEvent.IdleGmemberOptResponse: return typeof(IdleRspGmemberOpt);
				

				case EPacketEvent.IdleGbossSyncRequest: return typeof(IdleReqGbossSync);
				case EPacketEvent.IdleGbossSyncResponse: return typeof(IdleRspGbossSync);
				

				case EPacketEvent.IdleGbossRankRequest: return typeof(IdleReqGbossRank);
				case EPacketEvent.IdleGbossRankResponse: return typeof(IdleRspGbossRank);
				

				case EPacketEvent.IdleGbossFightRequest: return typeof(IdleReqGbossFight);
				case EPacketEvent.IdleGbossFightResponse: return typeof(IdleRspGbossFight);
				

				case EPacketEvent.IdleGsklSyncRequest: return typeof(IdleReqGsklSync);
				case EPacketEvent.IdleGsklSyncResponse: return typeof(IdleRspGsklSync);
				

				case EPacketEvent.IdleGsklUpRequest: return typeof(IdleReqGsklUp);
				case EPacketEvent.IdleGsklUpResponse: return typeof(IdleRspGsklUp);
				

				case EPacketEvent.IdleGsklResetRequest: return typeof(IdleReqGsklReset);
				case EPacketEvent.IdleGsklResetResponse: return typeof(IdleRspGsklReset);
				

				case EPacketEvent.IdleGfireSyncRequest: return typeof(IdleReqGfireSync);
				case EPacketEvent.IdleGfireSyncResponse: return typeof(IdleRspGfireSync);
				

				case EPacketEvent.IdleGfireRegRequest: return typeof(IdleReqGfireReg);
				case EPacketEvent.IdleGfireRegResponse: return typeof(IdleRspGfireReg);
				

				case EPacketEvent.IdleGfireFightRequest: return typeof(IdleReqGfireFight);
				case EPacketEvent.IdleGfireFightResponse: return typeof(IdleRspGfireFight);
				

				case EPacketEvent.IdleGfireRankRequest: return typeof(IdleReqGfireRank);
				case EPacketEvent.IdleGfireRankResponse: return typeof(IdleRspGfireRank);
				

				case EPacketEvent.IdleGveSyncRequest: return typeof(IdleReqGveSync);
				case EPacketEvent.IdleGveSyncResponse: return typeof(IdleRspGveSync);
				

				case EPacketEvent.IdleGveRankRequest: return typeof(IdleReqGveRank);
				case EPacketEvent.IdleGveRankResponse: return typeof(IdleRspGveRank);
				

				case EPacketEvent.IdleGveFightRequest: return typeof(IdleReqGveFight);
				case EPacketEvent.IdleGveFightResponse: return typeof(IdleRspGveFight);
				

				case EPacketEvent.IdleGveTaskRequest: return typeof(IdleReqGveTask);
				case EPacketEvent.IdleGveTaskResponse: return typeof(IdleRspGveTask);
				

				case EPacketEvent.IdleGveClaimRequest: return typeof(IdleReqGveClaim);
				case EPacketEvent.IdleGveClaimResponse: return typeof(IdleRspGveClaim);
				

				case EPacketEvent.IdleGveMapClaimRequest: return typeof(IdleReqGveMapClaim);
				case EPacketEvent.IdleGveMapClaimResponse: return typeof(IdleRspGveMapClaim);
				

				case EPacketEvent.IdleTrialRequest: return typeof(IdleReqTrial);
				case EPacketEvent.IdleTrialResponse: return typeof(IdleRspTrial);
				

				case EPacketEvent.IdleTrialRankRequest: return typeof(IdleReqTrialRank);
				case EPacketEvent.IdleTrialRankResponse: return typeof(IdleRspTrialRank);
				

				case EPacketEvent.IdleTrialFightRequest: return typeof(IdleReqTrialFight);
				case EPacketEvent.IdleTrialFightResponse: return typeof(IdleRspTrialFight);
				

				case EPacketEvent.IdleTrialVideoRequest: return typeof(IdleReqTrialVideo);
				case EPacketEvent.IdleTrialVideoResponse: return typeof(IdleRspTrialVideo);
				

				case EPacketEvent.IdleTrialTlRequest: return typeof(IdleReqTrialTl);
				case EPacketEvent.IdleTrialTlResponse: return typeof(IdleRspTrialTl);
				

				case EPacketEvent.IdlePvpSyncRequest: return typeof(IdleReqPvpSync);
				case EPacketEvent.IdlePvpSyncResponse: return typeof(IdleRspPvpSync);
				

				case EPacketEvent.IdlePvpCampRequest: return typeof(IdleReqPvpCamp);
				case EPacketEvent.IdlePvpCampResponse: return typeof(IdleRspPvpCamp);
				

				case EPacketEvent.IdlePvpRefreshRequest: return typeof(IdleReqPvpRefresh);
				case EPacketEvent.IdlePvpRefreshResponse: return typeof(IdleRspPvpRefresh);
				

				case EPacketEvent.IdlePvpFightRequest: return typeof(IdleReqPvpFight);
				case EPacketEvent.IdlePvpFightResponse: return typeof(IdleRspPvpFight);
				

				case EPacketEvent.IdlePlogsRequest: return typeof(IdleReqPlogs);
				case EPacketEvent.IdlePlogsResponse: return typeof(IdleRspPlogs);
				

				case EPacketEvent.IdlePvpRankRequest: return typeof(IdleReqPvpRank);
				case EPacketEvent.IdlePvpRankResponse: return typeof(IdleRspPvpRank);
				

				case EPacketEvent.IdleVideoRequest: return typeof(IdleReqVideo);
				case EPacketEvent.IdleVideoResponse: return typeof(IdleRspVideo);
				

				case EPacketEvent.IdlePvpTicketRequest: return typeof(IdleReqPvpTicket);
				case EPacketEvent.IdlePvpTicketResponse: return typeof(IdleRspPvpTicket);
				

				case EPacketEvent.IdlePmarketRequest: return typeof(IdleReqPmarket);
				case EPacketEvent.IdlePmarketResponse: return typeof(IdleRspPmarket);
				

				case EPacketEvent.IdlePmarketBuyRequest: return typeof(IdleReqPmarketBuy);
				case EPacketEvent.IdlePmarketBuyResponse: return typeof(IdleRspPmarketBuy);
				

				case EPacketEvent.IdleJoinpvpSyncRequest: return typeof(IdleReqJoinpvpSync);
				case EPacketEvent.IdleJoinpvpSyncResponse: return typeof(IdleRspJoinpvpSync);
				

				case EPacketEvent.IdleP3pSyncRequest: return typeof(IdleReqP3pSync);
				case EPacketEvent.IdleP3pSyncResponse: return typeof(IdleRspP3pSync);
				

				case EPacketEvent.IdleP3pCampRequest: return typeof(IdleReqP3pCamp);
				case EPacketEvent.IdleP3pCampResponse: return typeof(IdleRspP3pCamp);
				

				case EPacketEvent.IdleP3pMatchRequest: return typeof(IdleReqP3pMatch);
				case EPacketEvent.IdleP3pMatchResponse: return typeof(IdleRspP3pMatch);
				

				case EPacketEvent.IdleP3pFightRequest: return typeof(IdleReqP3pFight);
				case EPacketEvent.IdleP3pFightResponse: return typeof(IdleRspP3pFight);
				

				case EPacketEvent.IdleP3pHonorRequest: return typeof(IdleReqP3pHonor);
				case EPacketEvent.IdleP3pHonorResponse: return typeof(IdleRspP3pHonor);
				

				case EPacketEvent.IdleP3pLogsRequest: return typeof(IdleReqP3pLogs);
				case EPacketEvent.IdleP3pLogsResponse: return typeof(IdleRspP3pLogs);
				

				case EPacketEvent.IdleP3pVideoRequest: return typeof(IdleReqP3pVideo);
				case EPacketEvent.IdleP3pVideoResponse: return typeof(IdleRspP3pVideo);
				

				case EPacketEvent.IdleP3pInfoRequest: return typeof(IdleReqP3pInfo);
				case EPacketEvent.IdleP3pInfoResponse: return typeof(IdleRspP3pInfo);
				

				case EPacketEvent.IdleFpkCampRequest: return typeof(IdleReqFpkCamp);
				case EPacketEvent.IdleFpkCampResponse: return typeof(IdleRspFpkCamp);
				

				case EPacketEvent.IdleHtaskRequest: return typeof(IdleReqHtask);
				case EPacketEvent.IdleHtaskResponse: return typeof(IdleRspHtask);
				

				case EPacketEvent.IdleHtaskStartRequest: return typeof(IdleReqHtaskStart);
				case EPacketEvent.IdleHtaskStartResponse: return typeof(IdleRspHtaskStart);
				

				case EPacketEvent.IdleHtaskSpeedupRequest: return typeof(IdleReqHtaskSpeedup);
				case EPacketEvent.IdleHtaskSpeedupResponse: return typeof(IdleRspHtaskSpeedup);
				

				case EPacketEvent.IdleHtaskRecRequest: return typeof(IdleReqHtaskRec);
				case EPacketEvent.IdleHtaskRecResponse: return typeof(IdleRspHtaskRec);
				

				case EPacketEvent.IdleHtaskGemRequest: return typeof(IdleReqHtaskGem);
				case EPacketEvent.IdleHtaskGemResponse: return typeof(IdleRspHtaskGem);
				

				case EPacketEvent.IdleHtaskAddRequest: return typeof(IdleReqHtaskAdd);
				case EPacketEvent.IdleHtaskAddResponse: return typeof(IdleRspHtaskAdd);
				

				case EPacketEvent.IdleHtaskAutoRequest: return typeof(IdleReqHtaskAuto);
				case EPacketEvent.IdleHtaskAutoResponse: return typeof(IdleRspHtaskAuto);
				

				case EPacketEvent.IdleAchieveRequest: return typeof(IdleReqAchieve);
				case EPacketEvent.IdleAchieveResponse: return typeof(IdleRspAchieve);
				

				case EPacketEvent.IdleAchieveClaimRequest: return typeof(IdleReqAchieveClaim);
				case EPacketEvent.IdleAchieveClaimResponse: return typeof(IdleRspAchieveClaim);
				

				case EPacketEvent.IdleAchievieAttentionRequest: return typeof(IdleReqAchievieAttention);
				case EPacketEvent.IdleAchievieAttentionResponse: return typeof(IdleRspAchievieAttention);
				

				case EPacketEvent.IdlePayRequest: return typeof(IdleReqPay);
				case EPacketEvent.IdlePayResponse: return typeof(IdleRspPay);
				

				case EPacketEvent.IdleFpayRequest: return typeof(IdleReqFpay);
				case EPacketEvent.IdleFpayResponse: return typeof(IdleRspFpay);
				

				case EPacketEvent.IdlePay2Request: return typeof(IdleReqPay2);
				case EPacketEvent.IdlePay2Response: return typeof(IdleRspPay2);
				

				case EPacketEvent.IdleGorderRequest: return typeof(IdleReqGorder);
				case EPacketEvent.IdleGorderResponse: return typeof(IdleRspGorder);
				

				case EPacketEvent.IdleGpayRequest: return typeof(IdleReqGpay);
				case EPacketEvent.IdleGpayResponse: return typeof(IdleRspGpay);
				

				case EPacketEvent.IdleChpayRequest: return typeof(IdleReqChpay);
				case EPacketEvent.IdleChpayResponse: return typeof(IdleRspChpay);
				

				case EPacketEvent.IdleAmznpayRequest: return typeof(IdleReqAmznpay);
				case EPacketEvent.IdleAmznpayResponse: return typeof(IdleRspAmznpay);
				

				case EPacketEvent.IdleOneforumRequest: return typeof(IdleReqOneforum);
				case EPacketEvent.IdleOneforumResponse: return typeof(IdleRspOneforum);
				

				case EPacketEvent.IdleGpay2Request: return typeof(IdleReqGpay2);
				case EPacketEvent.IdleGpay2Response: return typeof(IdleRspGpay2);
				

				case EPacketEvent.IdleVoucherRequest: return typeof(IdleReqVoucher);
				case EPacketEvent.IdleVoucherResponse: return typeof(IdleRspVoucher);
				

				case EPacketEvent.IdleStoreinfoRequest: return typeof(IdleReqStoreinfo);
				case EPacketEvent.IdleStoreinfoResponse: return typeof(IdleRspStoreinfo);
				

				case EPacketEvent.IdleHmarketBuyRequest: return typeof(IdleReqHmarketBuy);
				case EPacketEvent.IdleHmarketBuyResponse: return typeof(IdleRspHmarketBuy);
				

				case EPacketEvent.IdleHmarketSyncRequest: return typeof(IdleReqHmarketSync);
				case EPacketEvent.IdleHmarketSyncResponse: return typeof(IdleRspHmarketSync);
				

				case EPacketEvent.IdleBraveMarketBuyRequest: return typeof(IdleReqBraveMarketBuy);
				case EPacketEvent.IdleBraveMarketBuyResponse: return typeof(IdleRspBraveMarketBuy);
				

				case EPacketEvent.IdleBraveMarketSyncRequest: return typeof(IdleReqBraveMarketSync);
				case EPacketEvent.IdleBraveMarketSyncResponse: return typeof(IdleRspBraveMarketSync);
				

				case EPacketEvent.IdleHmarketRefreshRequest: return typeof(IdleReqHmarketRefresh);
				case EPacketEvent.IdleHmarketRefreshResponse: return typeof(IdleRspHmarketRefresh);
				

				case EPacketEvent.IdleAloginRequest: return typeof(IdleReqAlogin);
				case EPacketEvent.IdleAloginResponse: return typeof(IdleRspAlogin);
				

				case EPacketEvent.IdleTaskClaimRequest: return typeof(IdleReqTaskClaim);
				case EPacketEvent.IdleTaskClaimResponse: return typeof(IdleRspTaskClaim);
				

				case EPacketEvent.IdleOnlineClaimRequest: return typeof(IdleReqOnlineClaim);
				case EPacketEvent.IdleOnlineClaimResponse: return typeof(IdleRspOnlineClaim);
				

				case EPacketEvent.IdleFeedbackRequest: return typeof(IdleReqFeedback);
				case EPacketEvent.IdleFeedbackResponse: return typeof(IdleRspFeedback);
				

				case EPacketEvent.IdleGmarketBuyRequest: return typeof(IdleReqGmarketBuy);
				case EPacketEvent.IdleGmarketBuyResponse: return typeof(IdleRspGmarketBuy);
				

				case EPacketEvent.IdleGmarketSyncRequest: return typeof(IdleReqGmarketSync);
				case EPacketEvent.IdleGmarketSyncResponse: return typeof(IdleRspGmarketSync);
				

				case EPacketEvent.IdleGmarketRefreshRequest: return typeof(IdleReqGmarketRefresh);
				case EPacketEvent.IdleGmarketRefreshResponse: return typeof(IdleRspGmarketRefresh);
				

				case EPacketEvent.IdleGmarketExchangeRequest: return typeof(IdleReqGmarketExchange);
				case EPacketEvent.IdleGmarketExchangeResponse: return typeof(IdleRspGmarketExchange);
				

				case EPacketEvent.IdleMergeTreasureRequest: return typeof(IdleReqMergeTreasure);
				case EPacketEvent.IdleMergeTreasureResponse: return typeof(IdleRspMergeTreasure);
				

				case EPacketEvent.IdleNgwSyncRequest: return typeof(IdleReqNgwSync);
				case EPacketEvent.IdleNgwSyncResponse: return typeof(IdleRspNgwSync);
				

				case EPacketEvent.IdleNgwRankRequest: return typeof(IdleReqNgwRank);
				case EPacketEvent.IdleNgwRankResponse: return typeof(IdleRspNgwRank);
				

				case EPacketEvent.IdleNgwCampRequest: return typeof(IdleReqNgwCamp);
				case EPacketEvent.IdleNgwCampResponse: return typeof(IdleRspNgwCamp);
				

				case EPacketEvent.IdleNgwSholdRequest: return typeof(IdleReqNgwShold);
				case EPacketEvent.IdleNgwSholdResponse: return typeof(IdleRspNgwShold);
				

				case EPacketEvent.IdleNgwFightRequest: return typeof(IdleReqNgwFight);
				case EPacketEvent.IdleNgwFightResponse: return typeof(IdleRspNgwFight);
				

				case EPacketEvent.IdleNgwLupRequest: return typeof(IdleReqNgwLup);
				case EPacketEvent.IdleNgwLupResponse: return typeof(IdleRspNgwLup);
				

				case EPacketEvent.IdleNgwSetupRequest: return typeof(IdleReqNgwSetup);
				case EPacketEvent.IdleNgwSetupResponse: return typeof(IdleRspNgwSetup);
				

				case EPacketEvent.IdleNgwBuyRequest: return typeof(IdleReqNgwBuy);
				case EPacketEvent.IdleNgwBuyResponse: return typeof(IdleRspNgwBuy);
				

				case EPacketEvent.IdleNgwInfoRequest: return typeof(IdleReqNgwInfo);
				case EPacketEvent.IdleNgwInfoResponse: return typeof(IdleRspNgwInfo);
				

				case EPacketEvent.IdleNgwVideoRequest: return typeof(IdleReqNgwVideo);
				case EPacketEvent.IdleNgwVideoResponse: return typeof(IdleRspNgwVideo);
				

				case EPacketEvent.IdleNgwSweepRequest: return typeof(IdleReqNgwSweep);
				case EPacketEvent.IdleNgwSweepResponse: return typeof(IdleRspNgwSweep);
				

				case EPacketEvent.IdleCgwSyncRequest: return typeof(IdleReqCgwSync);
				case EPacketEvent.IdleCgwSyncResponse: return typeof(IdleRspCgwSync);
				

				case EPacketEvent.IdleCgwTeamRequest: return typeof(IdleReqCgwTeam);
				case EPacketEvent.IdleCgwTeamResponse: return typeof(IdleRspCgwTeam);
				

				case EPacketEvent.IdleCgwRegRequest: return typeof(IdleReqCgwReg);
				case EPacketEvent.IdleCgwRegResponse: return typeof(IdleRspCgwReg);
				

				case EPacketEvent.IdleCgwHonorRequest: return typeof(IdleReqCgwHonor);
				case EPacketEvent.IdleCgwHonorResponse: return typeof(IdleRspCgwHonor);
				

				case EPacketEvent.IdleCgwRecordRequest: return typeof(IdleReqCgwRecord);
				case EPacketEvent.IdleCgwRecordResponse: return typeof(IdleRspCgwRecord);
				

				case EPacketEvent.IdleCgwRaceRequest: return typeof(IdleReqCgwRace);
				case EPacketEvent.IdleCgwRaceResponse: return typeof(IdleRspCgwRace);
				

				case EPacketEvent.IdleCgwLogRequest: return typeof(IdleReqCgwLog);
				case EPacketEvent.IdleCgwLogResponse: return typeof(IdleRspCgwLog);
				

				case EPacketEvent.IdleGpvpSyncRequest: return typeof(IdleReqGpvpSync);
				case EPacketEvent.IdleGpvpSyncResponse: return typeof(IdleRspGpvpSync);
				

				case EPacketEvent.IdleGpvpSetCampRequest: return typeof(IdleReqGpvpSetCamp);
				case EPacketEvent.IdleGpvpSetCampResponse: return typeof(IdleRspGpvpSetCamp);
				

				case EPacketEvent.IdleCreateGpvpteamRequest: return typeof(IdleReqCreateGpvpteam);
				case EPacketEvent.IdleCreateGpvpteamResponse: return typeof(IdleRspCreateGpvpteam);
				

				case EPacketEvent.IdleDismissGpvpteamRequest: return typeof(IdleReqDismissGpvpteam);
				case EPacketEvent.IdleDismissGpvpteamResponse: return typeof(IdleRspDismissGpvpteam);
				

				case EPacketEvent.IdleGpvpMatchRequest: return typeof(IdleReqGpvpMatch);
				case EPacketEvent.IdleGpvpMatchResponse: return typeof(IdleRspGpvpMatch);
				

				case EPacketEvent.IdleSubmitGpvpteamRequest: return typeof(IdleReqSubmitGpvpteam);
				case EPacketEvent.IdleSubmitGpvpteamResponse: return typeof(IdleRspSubmitGpvpteam);
				

				case EPacketEvent.IdleGpvpLeaderopRequest: return typeof(IdleReqGpvpLeaderop);
				case EPacketEvent.IdleGpvpLeaderopResponse: return typeof(IdleRspGpvpLeaderop);
				

				case EPacketEvent.IdleGpvpFriendslistRequest: return typeof(IdleReqGpvpFriendslist);
				case EPacketEvent.IdleGpvpFriendslistResponse: return typeof(IdleRspGpvpFriendslist);
				

				case EPacketEvent.IdleGpvpInvitelistRequest: return typeof(IdleReqGpvpInvitelist);
				case EPacketEvent.IdleGpvpInvitelistResponse: return typeof(IdleRspGpvpInvitelist);
				

				case EPacketEvent.IdleGpvpRefreshRequest: return typeof(IdleReqGpvpRefresh);
				case EPacketEvent.IdleGpvpRefreshResponse: return typeof(IdleRspGpvpRefresh);
				

				case EPacketEvent.IdleGpvpMbropRequest: return typeof(IdleReqGpvpMbrop);
				case EPacketEvent.IdleGpvpMbropResponse: return typeof(IdleRspGpvpMbrop);
				

				case EPacketEvent.IdleGpvpRanklistRequest: return typeof(IdleReqGpvpRanklist);
				case EPacketEvent.IdleGpvpRanklistResponse: return typeof(IdleRspGpvpRanklist);
				

				case EPacketEvent.IdleChangeGpvpteamRequest: return typeof(IdleReqChangeGpvpteam);
				case EPacketEvent.IdleChangeGpvpteamResponse: return typeof(IdleRspChangeGpvpteam);
				

				case EPacketEvent.IdleGpvpApplylistRequest: return typeof(IdleReqGpvpApplylist);
				case EPacketEvent.IdleGpvpApplylistResponse: return typeof(IdleRspGpvpApplylist);
				

				case EPacketEvent.IdleGpvpMbrRequest: return typeof(IdleReqGpvpMbr);
				case EPacketEvent.IdleGpvpMbrResponse: return typeof(IdleRspGpvpMbr);
				

				case EPacketEvent.IdleGpvpGrpRequest: return typeof(IdleReqGpvpGrp);
				case EPacketEvent.IdleGpvpGrpResponse: return typeof(IdleRspGpvpGrp);
				

				case EPacketEvent.IdleGpvpFightRequest: return typeof(IdleReqGpvpFight);
				case EPacketEvent.IdleGpvpFightResponse: return typeof(IdleRspGpvpFight);
				

				case EPacketEvent.IdleGpvpLogsRequest: return typeof(IdleReqGpvpLogs);
				case EPacketEvent.IdleGpvpLogsResponse: return typeof(IdleRspGpvpLogs);
				

				case EPacketEvent.IdleGpvpWlogRequest: return typeof(IdleReqGpvpWlog);
				case EPacketEvent.IdleGpvpWlogResponse: return typeof(IdleRspGpvpWlog);
				

				case EPacketEvent.IdleGpvpVideoRequest: return typeof(IdleReqGpvpVideo);
				case EPacketEvent.IdleGpvpVideoResponse: return typeof(IdleRspGpvpVideo);
				

				case EPacketEvent.IdlePetOpRequest: return typeof(IdleReqPetOp);
				case EPacketEvent.IdlePetOpResponse: return typeof(IdleRspPetOp);
				

				case EPacketEvent.IdleBbossBuyRequest: return typeof(IdleReqBbossBuy);
				case EPacketEvent.IdleBbossBuyResponse: return typeof(IdleRspBbossBuy);
				

				case EPacketEvent.IdleBbossSynRequest: return typeof(IdleReqBbossSyn);
				case EPacketEvent.IdleBbossSynResponse: return typeof(IdleRspBbossSyn);
				

				case EPacketEvent.IdleBbossFightRequest: return typeof(IdleReqBbossFight);
				case EPacketEvent.IdleBbossFightResponse: return typeof(IdleRspBbossFight);
				

				case EPacketEvent.IdleBbossBatchRequest: return typeof(IdleReqBbossBatch);
				case EPacketEvent.IdleBbossBatchResponse: return typeof(IdleRspBbossBatch);
				

				case EPacketEvent.IdleSpkSyncRequest: return typeof(IdleReqSpkSync);
				case EPacketEvent.IdleSpkSyncResponse: return typeof(IdleRspSpkSync);
				

				case EPacketEvent.IdleSpkCampRequest: return typeof(IdleReqSpkCamp);
				case EPacketEvent.IdleSpkCampResponse: return typeof(IdleRspSpkCamp);
				

				case EPacketEvent.IdleSpkFightRequest: return typeof(IdleReqSpkFight);
				case EPacketEvent.IdleSpkFightResponse: return typeof(IdleRspSpkFight);
				

				case EPacketEvent.IdleSpkBufRequest: return typeof(IdleReqSpkBuf);
				case EPacketEvent.IdleSpkBufResponse: return typeof(IdleRspSpkBuf);
				

				case EPacketEvent.IdleSpkRankRequest: return typeof(IdleReqSpkRank);
				case EPacketEvent.IdleSpkRankResponse: return typeof(IdleRspSpkRank);
				

				case EPacketEvent.IdleSpkBuyRequest: return typeof(IdleReqSpkBuy);
				case EPacketEvent.IdleSpkBuyResponse: return typeof(IdleRspSpkBuy);
				

				case EPacketEvent.IdleIslandSyncRequest: return typeof(IdleReqIslandSync);
				case EPacketEvent.IdleIslandSyncResponse: return typeof(IdleRspIslandSync);
				

				case EPacketEvent.IdleIslandTowerRequest: return typeof(IdleReqIslandTower);
				case EPacketEvent.IdleIslandTowerResponse: return typeof(IdleRspIslandTower);
				

				case EPacketEvent.IdleIslandOpRequest: return typeof(IdleReqIslandOp);
				case EPacketEvent.IdleIslandOpResponse: return typeof(IdleRspIslandOp);
				

				case EPacketEvent.IdleIslandLandRequest: return typeof(IdleReqIslandLand);
				case EPacketEvent.IdleIslandLandResponse: return typeof(IdleRspIslandLand);
				

				case EPacketEvent.IdleIslandBoxRequest: return typeof(IdleReqIslandBox);
				case EPacketEvent.IdleIslandBoxResponse: return typeof(IdleRspIslandBox);
				

				case EPacketEvent.IdleIslandNpcRequest: return typeof(IdleReqIslandNpc);
				case EPacketEvent.IdleIslandNpcResponse: return typeof(IdleRspIslandNpc);
				

				case EPacketEvent.IdleIslandBossRequest: return typeof(IdleReqIslandBoss);
				case EPacketEvent.IdleIslandBossResponse: return typeof(IdleRspIslandBoss);
				

				case EPacketEvent.IdleIslandFightRequest: return typeof(IdleReqIslandFight);
				case EPacketEvent.IdleIslandFightResponse: return typeof(IdleRspIslandFight);
				

				case EPacketEvent.IdleIslandBuyRequest: return typeof(IdleReqIslandBuy);
				case EPacketEvent.IdleIslandBuyResponse: return typeof(IdleRspIslandBuy);
				

				case EPacketEvent.IdleIslandBatchRequest: return typeof(IdleReqIslandBatch);
				case EPacketEvent.IdleIslandBatchResponse: return typeof(IdleRspIslandBatch);
				

				case EPacketEvent.IdleIslandSweepRequest: return typeof(IdleReqIslandSweep);
				case EPacketEvent.IdleIslandSweepResponse: return typeof(IdleRspIslandSweep);
				

				case EPacketEvent.IdleIslandBgetRequest: return typeof(IdleReqIslandBget);
				case EPacketEvent.IdleIslandBgetResponse: return typeof(IdleRspIslandBget);
				

				case EPacketEvent.IdleIslandIboatSyncRequest: return typeof(IdleReqIboatSync);
				case EPacketEvent.IdleIslandIboatSyncResponse: return typeof(IdleRspIboatSync);
				

				case EPacketEvent.IdleIslandIboatStartRequest: return typeof(IdleReqIboatStart);
				case EPacketEvent.IdleIslandIboatStartResponse: return typeof(IdleRspIboatStart);
				

				case EPacketEvent.IdleIslandIboatXpRequest: return typeof(IdleReqIboatXp);
				case EPacketEvent.IdleIslandIboatXpResponse: return typeof(IdleRspIboatXp);
				

				case EPacketEvent.IdleIslandIboatXpopRequest: return typeof(IdleReqIboatXpop);
				case EPacketEvent.IdleIslandIboatXpopResponse: return typeof(IdleRspIboatXpop);
				

				case EPacketEvent.IdleIslandIboatShopRequest: return typeof(IdleReqIboatShop);
				case EPacketEvent.IdleIslandIboatShopResponse: return typeof(IdleRspIboatShop);
				

				case EPacketEvent.IdleIslandIboatBuyRequest: return typeof(IdleReqIboatBuy);
				case EPacketEvent.IdleIslandIboatBuyResponse: return typeof(IdleRspIboatBuy);
				

				case EPacketEvent.IdleIslandIboatArmRequest: return typeof(IdleReqIboatArm);
				case EPacketEvent.IdleIslandIboatArmResponse: return typeof(IdleRspIboatArm);
				

				case EPacketEvent.IdleIslandIboatSklRequest: return typeof(IdleReqIboatSkl);
				case EPacketEvent.IdleIslandIboatSklResponse: return typeof(IdleRspIboatSkl);
				

				case EPacketEvent.IdleIslandIboatNameRequest: return typeof(IdleReqIboatName);
				case EPacketEvent.IdleIslandIboatNameResponse: return typeof(IdleRspIboatName);
				

				case EPacketEvent.IdleIslandIboatFsyncRequest: return typeof(IdleReqIboatFsync);
				case EPacketEvent.IdleIslandIboatFsyncResponse: return typeof(IdleRspIboatFsync);
				

				case EPacketEvent.IdleIslandIboatFproRequest: return typeof(IdleReqIboatFpro);
				case EPacketEvent.IdleIslandIboatFproResponse: return typeof(IdleRspIboatFpro);
				

				case EPacketEvent.IdleIslandIboatUseRequest: return typeof(IdleReqIboatUse);
				case EPacketEvent.IdleIslandIboatUseResponse: return typeof(IdleRspIboatUse);
				

				case EPacketEvent.IdleBeatNienRequest: return typeof(IdleReqBeatNien);
				case EPacketEvent.IdleBeatNienResponse: return typeof(IdleRspBeatNien);
				

				case EPacketEvent.IdleSeallandSyncRequest: return typeof(IdleReqSealandSync);
				case EPacketEvent.IdleSeallandSyncResponse: return typeof(IdleRspSealandSync);
				

				case EPacketEvent.IdleSeallandChallengeBuyRequest: return typeof(IdleReqSealandChallengeBuy);
				case EPacketEvent.IdleSeallandChallengeBuyResponse: return typeof(IdleRspSealandChallengeBuy);
				

				case EPacketEvent.IdleSeallandFightRequest: return typeof(IdleReqSealandFight);
				case EPacketEvent.IdleSeallandFightResponse: return typeof(IdleRspSealandFight);
				

				case EPacketEvent.IdleSeallandRewardRequest: return typeof(IdleReqSealandReward);
				case EPacketEvent.IdleSeallandRewardResponse: return typeof(IdleRspSealandReward);
				

				case EPacketEvent.IdleSeallandSweepBuyRequest: return typeof(IdleReqSealandSweepBuy);
				case EPacketEvent.IdleSeallandSweepBuyResponse: return typeof(IdleRspSealandSweepBuy);
				

				case EPacketEvent.IdleSeallandMarketBuyRequest: return typeof(IdleReqSealandMarketBuy);
				case EPacketEvent.IdleSeallandMarketBuyResponse: return typeof(IdleRspSealandMarketBuy);
				

				case EPacketEvent.IdleBraveSweepRequest: return typeof(IdleReqBraveSweep);
				case EPacketEvent.IdleBraveSweepResponse: return typeof(IdleRspBraveSweep);
				

				case EPacketEvent.IdleMonthmarketBuyRequest: return typeof(IdleReqMonthmarketBuy);
				case EPacketEvent.IdleMonthmarketBuyResponse: return typeof(IdleRspMonthmarketBuy);
				

				case EPacketEvent.IdleMonthmarketSyncRequest: return typeof(IdleReqMonthmarketSync);
				case EPacketEvent.IdleMonthmarketSyncResponse: return typeof(IdleRspMonthmarketSync);
				

				case EPacketEvent.IdleActivityRequest: return typeof(IdleReqActivity);
				case EPacketEvent.IdleActivityResponse: return typeof(IdleRspActivity);
				

				case EPacketEvent.IdleActivitySignRequest: return typeof(IdleReqActivitySign);
				case EPacketEvent.IdleActivitySignResponse: return typeof(IdleRspActivitySign);
				

				case EPacketEvent.IdleMazeOpenRequest: return typeof(IdleReqMazeOpen);
				case EPacketEvent.IdleMazeOpenResponse: return typeof(IdleRspMazeOpen);
				

				case EPacketEvent.IdleMazeChangeHeroRequest: return typeof(IdleReqMazeChangeHero);
				case EPacketEvent.IdleMazeChangeHeroResponse: return typeof(IdleRspMazeChangeHero);
				

				case EPacketEvent.IdleMazeOpen2Request: return typeof(IdleReqMazeOpen2);
				case EPacketEvent.IdleMazeOpen2Response: return typeof(IdleRspMazeOpen2);
				

				case EPacketEvent.IdleMazeBuyRequest: return typeof(IdleReqMazeBuy);
				case EPacketEvent.IdleMazeBuyResponse: return typeof(IdleRspMazeBuy);
				

				case EPacketEvent.IdleMazeSyncRequest: return typeof(IdleReqMazeSync);
				case EPacketEvent.IdleMazeSyncResponse: return typeof(IdleRspMazeSync);
				

				case EPacketEvent.IdleMazeBreakRequest: return typeof(IdleReqMazeBreak);
				case EPacketEvent.IdleMazeBreakResponse: return typeof(IdleRspMazeBreak);
				

				case EPacketEvent.IdleFetchSactRequest: return typeof(IdleReqFetchSact);
				case EPacketEvent.IdleFetchSactResponse: return typeof(IdleRspFetchSact);
				

				case EPacketEvent.IdleSactSummerBuyRequest: return typeof(IdleReqSactSummerBuy);
				case EPacketEvent.IdleSactSummerBuyResponse: return typeof(IdleRspSactSummerBuy);
				

				case EPacketEvent.IdleHeroLogRequest: return typeof(IdleReqHeroLog);
				case EPacketEvent.IdleHeroLogResponse: return typeof(IdleRspHeroLog);
				

				case EPacketEvent.IdleBraveOpenRequest: return typeof(IdleReqBraveOpen);
				case EPacketEvent.IdleBraveOpenResponse: return typeof(IdleRspBraveOpen);
				

				case EPacketEvent.IdleBraveAltarRequest: return typeof(IdleReqBraveAltar);
				case EPacketEvent.IdleBraveAltarResponse: return typeof(IdleRspBraveAltar);
				

				case EPacketEvent.IdleBraveBuyRequest: return typeof(IdleReqBraveBuy);
				case EPacketEvent.IdleBraveBuyResponse: return typeof(IdleRspBraveBuy);
				

				case EPacketEvent.IdleWpvpSyncRequest: return typeof(IdleReqWsync);
				case EPacketEvent.IdleWpvpSyncResponse: return typeof(IdleRspWsync);
				

				case EPacketEvent.IdleWpvpHonorRequest: return typeof(IdleReqWhonor);
				case EPacketEvent.IdleWpvpHonorResponse: return typeof(IdleRspWhonor);
				

				case EPacketEvent.IdleWpvpDailyRequest: return typeof(IdleReqWdaily);
				case EPacketEvent.IdleWpvpDailyResponse: return typeof(IdleRspWdaily);
				

				case EPacketEvent.IdleWpvpMatchRequest: return typeof(IdleReqWmatch);
				case EPacketEvent.IdleWpvpMatchResponse: return typeof(IdleRspWmatch);
				

				case EPacketEvent.IdleWpvpCampRequest: return typeof(IdleReqWcamp);
				case EPacketEvent.IdleWpvpCampResponse: return typeof(IdleRspWcamp);
				

				case EPacketEvent.IdleWpvpFightRequest: return typeof(IdleReqWfight);
				case EPacketEvent.IdleWpvpFightResponse: return typeof(IdleRspWfight);
				

				case EPacketEvent.IdleWpvpLikeRequest: return typeof(IdleReqWlike);
				case EPacketEvent.IdleWpvpLikeResponse: return typeof(IdleRspWlike);
				

				case EPacketEvent.IdleWpvpInfoRequest: return typeof(IdleReqWinfo);
				case EPacketEvent.IdleWpvpInfoResponse: return typeof(IdleRspWinfo);
				

				case EPacketEvent.IdleWpvpZoneRequest: return typeof(IdleReqWzone);
				case EPacketEvent.IdleWpvpZoneResponse: return typeof(IdleRspWzone);
				

				case EPacketEvent.IdleWpvpLoger1Request: return typeof(IdleReqWloger1);
				case EPacketEvent.IdleWpvpLoger1Response: return typeof(IdleRspWloger1);
				

				case EPacketEvent.IdleWpvpLog1Request: return typeof(IdleReqWlog1);
				case EPacketEvent.IdleWpvpLog1Response: return typeof(IdleRspWlog1);
				

				case EPacketEvent.IdleWpvpVideo1Request: return typeof(IdleReqWvideo1);
				case EPacketEvent.IdleWpvpVideo1Response: return typeof(IdleRspWvideo1);
				

				case EPacketEvent.IdleWpvpLog2Request: return typeof(IdleReqWlog2);
				case EPacketEvent.IdleWpvpLog2Response: return typeof(IdleRspWlog2);
				

				case EPacketEvent.IdleWpvpVideo2Request: return typeof(IdleReqWvideo2);
				case EPacketEvent.IdleWpvpVideo2Response: return typeof(IdleRspWvideo2);
				

				case EPacketEvent.IdleTutorialRequest: return typeof(IdleReqTutorial);
				case EPacketEvent.IdleTutorialResponse: return typeof(IdleRspTutorial);
				

				case EPacketEvent.IdleRactReceiveRequest: return typeof(IdleReqRactReceive);
				case EPacketEvent.IdleRactReceiveResponse: return typeof(IdleRspRactReceive);
				

				case EPacketEvent.IdleRactPowerRequest: return typeof(IdleReqRactPower);
				case EPacketEvent.IdleRactPowerResponse: return typeof(IdleRspRactPower);
				

				case EPacketEvent.IdleTaskConvertRequest: return typeof(IdleReqTaskConvert);
				case EPacketEvent.IdleTaskConvertResponse: return typeof(IdleRspTaskConvert);
				

				case EPacketEvent.IdleFetchActivityRequest: return typeof(IdleReqFetchActivity);
				case EPacketEvent.IdleFetchActivityResponse: return typeof(IdleRspFetchActivity);
				

				case EPacketEvent.IdleMonopolyDiceRequest: return typeof(IdleReqMonopolyDice);
				case EPacketEvent.IdleMonopolyDiceResponse: return typeof(IdleRspMonopolyDice);
				

				case EPacketEvent.IdleBuyDiceRequest: return typeof(IdleReqBuyDice);
				case EPacketEvent.IdleBuyDiceResponse: return typeof(IdleRspBuyDice);
				

				case EPacketEvent.IdleYoutuberRefreshRequest: return typeof(IdleReqYoutuberRefresh);
				case EPacketEvent.IdleYoutuberRefreshResponse: return typeof(IdleRspYoutuberRefresh);
				

				case EPacketEvent.IdleForgeBackRequest: return typeof(IdleReqForgeBack);
				case EPacketEvent.IdleForgeBackResponse: return typeof(IdleRspForgeBack);
				

				case EPacketEvent.IdleGoldCardRequest: return typeof(IdleReqGoldCard);
				case EPacketEvent.IdleGoldCardResponse: return typeof(IdleRspGoldCard);
				

				case EPacketEvent.IdleLimitGiftActivateRequest: return typeof(IdleReqLimitGiftActivate);
				case EPacketEvent.IdleLimitGiftActivateResponse: return typeof(IdleRspLimitGiftActivate);
				

				case EPacketEvent.IdleFollowRequest: return typeof(IdleReqFollow);
				case EPacketEvent.IdleFollowResponse: return typeof(IdleRspFollow);
				

				case EPacketEvent.IdleHtaskCommitRequest: return typeof(IdleReqHtaskCommit);
				case EPacketEvent.IdleHtaskCommitResponse: return typeof(IdleRspHtaskCommit);
				

				case EPacketEvent.IdleReSyncRequest: return typeof(IdleReqReSync);
				case EPacketEvent.IdleReSyncResponse: return typeof(IdleRspReSync);
				

				case EPacketEvent.IdleReCodeRequest: return typeof(IdleReqReCode);
				case EPacketEvent.IdleReCodeResponse: return typeof(IdleRspReCode);
				

				case EPacketEvent.IdleReBindRequest: return typeof(IdleReqReBind);
				case EPacketEvent.IdleReBindResponse: return typeof(IdleRspReBind);
				

				case EPacketEvent.IdleForgeArtifactRequest: return typeof(IdleReqForgeArtifact);
				case EPacketEvent.IdleForgeArtifactResponse: return typeof(IdleRspForgeArtifact);
				

				case EPacketEvent.IdleCrackArtifactRequest: return typeof(IdleReqCrackArtifact);
				case EPacketEvent.IdleCrackArtifactResponse: return typeof(IdleRspCrackArtifact);
				

				case EPacketEvent.IdleHeroForeverRequest: return typeof(IdleReqHeroForever);
				case EPacketEvent.IdleHeroForeverResponse: return typeof(IdleRspHeroForever);
				

				case EPacketEvent.IdleStSyncRequest: return typeof(IdleReqStSync);
				case EPacketEvent.IdleStSyncResponse: return typeof(IdleRspStSync);
				

				case EPacketEvent.IdleStSummonRequest: return typeof(IdleReqStSummon);
				case EPacketEvent.IdleStSummonResponse: return typeof(IdleRspStSummon);
				

				case EPacketEvent.IdleStSchangeRequest: return typeof(IdleReqStSchange);
				case EPacketEvent.IdleStSchangeResponse: return typeof(IdleRspStSchange);
				

				case EPacketEvent.IdleStRankRequest: return typeof(IdleReqStRank);
				case EPacketEvent.IdleStRankResponse: return typeof(IdleRspStRank);
				

				case EPacketEvent.IdleStHforgeRequest: return typeof(IdleReqStHforge);
				case EPacketEvent.IdleStHforgeResponse: return typeof(IdleRspStHforge);
				

				case EPacketEvent.IdleStHattrupRequest: return typeof(IdleReqStHattrup);
				case EPacketEvent.IdleStHattrupResponse: return typeof(IdleRspStHattrup);
				

				case EPacketEvent.IdleStHattrchangeRequest: return typeof(IdleReqStHattrchange);
				case EPacketEvent.IdleStHattrchangeResponse: return typeof(IdleRspStHattrchange);
				

				case EPacketEvent.IdleStHattractivateRequest: return typeof(IdleReqStHattractivate);
				case EPacketEvent.IdleStHattractivateResponse: return typeof(IdleRspStHattractivate);
				

				case EPacketEvent.IdleStVsyncRequest: return typeof(IdleReqStVsync);
				case EPacketEvent.IdleStVsyncResponse: return typeof(IdleRspStVsync);
				

				case EPacketEvent.IdleStVsync2Request: return typeof(IdleReqStVsync2);
				case EPacketEvent.IdleStVsync2Response: return typeof(IdleRspStVsync2);
				

				case EPacketEvent.IdleStVeventRequest: return typeof(IdleReqStVevent);
				case EPacketEvent.IdleStVeventResponse: return typeof(IdleRspStVevent);
				

				case EPacketEvent.IdleStVdiffRequest: return typeof(IdleReqStVdiff);
				case EPacketEvent.IdleStVdiffResponse: return typeof(IdleRspStVdiff);
				

				case EPacketEvent.IdleStHeartresolveRequest: return typeof(IdleReqStHeartresolve);
				case EPacketEvent.IdleStHeartresolveResponse: return typeof(IdleRspStHeartresolve);
				

				case EPacketEvent.IdleStVwipeRequest: return typeof(IdleReqStVwipe);
				case EPacketEvent.IdleStVwipeResponse: return typeof(IdleRspStVwipe);
				

				case EPacketEvent.IdleStVuseitemRequest: return typeof(IdleReqStVuseitem);
				case EPacketEvent.IdleStVuseitemResponse: return typeof(IdleRspStVuseitem);
				

				case EPacketEvent.IdleStEsyncRequest: return typeof(IdleReqStEsync);
				case EPacketEvent.IdleStEsyncResponse: return typeof(IdleRspStEsync);
				

				case EPacketEvent.IdleStEbuyRequest: return typeof(IdleReqStEbuy);
				case EPacketEvent.IdleStEbuyResponse: return typeof(IdleRspStEbuy);
				

				case EPacketEvent.IdleStEuseRequest: return typeof(IdleReqStEuse);
				case EPacketEvent.IdleStEuseResponse: return typeof(IdleRspStEuse);
				

				case EPacketEvent.IdleStEfightRequest: return typeof(IdleReqStEfight);
				case EPacketEvent.IdleStEfightResponse: return typeof(IdleRspStEfight);
				

				case EPacketEvent.IdleStErank1Request: return typeof(IdleReqStErank1);
				case EPacketEvent.IdleStErank1Response: return typeof(IdleRspStErank1);
				

				case EPacketEvent.IdleStErank2Request: return typeof(IdleReqStErank2);
				case EPacketEvent.IdleStErank2Response: return typeof(IdleRspStErank2);
				

				case EPacketEvent.IdleStEgetRequest: return typeof(IdleReqStEget);
				case EPacketEvent.IdleStEgetResponse: return typeof(IdleRspStEget);
				

				case EPacketEvent.IdleStEopenRequest: return typeof(IdleReqStEopen);
				case EPacketEvent.IdleStEopenResponse: return typeof(IdleRspStEopen);
				

				case EPacketEvent.IdleStAsyncRequest: return typeof(IdleReqStAsync);
				case EPacketEvent.IdleStAsyncResponse: return typeof(IdleRspStAsync);
				

				case EPacketEvent.IdleStErefreshRequest: return typeof(IdleReqStErefresh);
				case EPacketEvent.IdleStErefreshResponse: return typeof(IdleRspStErefresh);
				

				case EPacketEvent.IdleStHattrresetRequest: return typeof(IdleReqStHattrreset);
				case EPacketEvent.IdleStHattrresetResponse: return typeof(IdleRspStHattrreset);
				

				case EPacketEvent.IdleStTbackRequest: return typeof(IdleReqStTback);
				case EPacketEvent.IdleStTbackResponse: return typeof(IdleRspStTback);
				

				case EPacketEvent.IdleStChangenightRequest: return typeof(IdleReqStChangenight);
				case EPacketEvent.IdleStChangenightResponse: return typeof(IdleRspStChangenight);
				

				case EPacketEvent.IdleStStarresolveRequest: return typeof(IdleReqStStarresolve);
				case EPacketEvent.IdleStStarresolveResponse: return typeof(IdleRspStStarresolve);
				

				case EPacketEvent.IdleStSsyncRequest: return typeof(IdleReqStSsync);
				case EPacketEvent.IdleStSsyncResponse: return typeof(IdleRspStSsync);
				

				case EPacketEvent.IdleStSlvupRequest: return typeof(IdleReqStSlvup);
				case EPacketEvent.IdleStSlvupResponse: return typeof(IdleRspStSlvup);
				

				case EPacketEvent.IdleStSsweepRequest: return typeof(IdleReqStSsweep);
				case EPacketEvent.IdleStSsweepResponse: return typeof(IdleRspStSsweep);
				

				case EPacketEvent.IdleStSsklupRequest: return typeof(IdleReqStSsklup);
				case EPacketEvent.IdleStSsklupResponse: return typeof(IdleRspStSsklup);
				

				case EPacketEvent.IdleStSstoreRequest: return typeof(IdleReqStSstore);
				case EPacketEvent.IdleStSstoreResponse: return typeof(IdleRspStSstore);
				

				case EPacketEvent.IdleStSbuyRequest: return typeof(IdleReqStSbuy);
				case EPacketEvent.IdleStSbuyResponse: return typeof(IdleRspStSbuy);
				

				case EPacketEvent.IdleStSmapUnlockRequest: return typeof(IdleReqStSmapUnlock);
				case EPacketEvent.IdleStSmapUnlockResponse: return typeof(IdleRspStSmapUnlock);
				

				case EPacketEvent.IdleStSmapSyncRequest: return typeof(IdleReqStSmapSync);
				case EPacketEvent.IdleStSmapSyncResponse: return typeof(IdleRspStSmapSync);
				

				case EPacketEvent.IdleStScellUnlockRequest: return typeof(IdleReqStScellUnlock);
				case EPacketEvent.IdleStScellUnlockResponse: return typeof(IdleRspStScellUnlock);
				

				case EPacketEvent.IdleStScellDispRequest: return typeof(IdleReqStScellDisp);
				case EPacketEvent.IdleStScellDispResponse: return typeof(IdleRspStScellDisp);
				

				case EPacketEvent.IdleStScellFightRequest: return typeof(IdleReqStScellFight);
				case EPacketEvent.IdleStScellFightResponse: return typeof(IdleRspStScellFight);
				

				case EPacketEvent.IdleStSmapSettRequest: return typeof(IdleReqStSmapSett);
				case EPacketEvent.IdleStSmapSettResponse: return typeof(IdleRspStSmapSett);
				

				case EPacketEvent.IdleStSmapTeamRequest: return typeof(IdleReqStSmapTeam);
				case EPacketEvent.IdleStSmapTeamResponse: return typeof(IdleRspStSmapTeam);
				

				case EPacketEvent.IdleStSmapRankRequest: return typeof(IdleReqStSmapRank);
				case EPacketEvent.IdleStSmapRankResponse: return typeof(IdleRspStSmapRank);
				

				case EPacketEvent.IdleStSmapMbrRequest: return typeof(IdleReqStSmapMbr);
				case EPacketEvent.IdleStSmapMbrResponse: return typeof(IdleRspStSmapMbr);
				

				case EPacketEvent.IdleStSclickRequest: return typeof(IdleReqStSclick);
				case EPacketEvent.IdleStSclickResponse: return typeof(IdleRspStSclick);
				

				case EPacketEvent.IdleSpetResetRequest: return typeof(IdleReqSpetReset);
				case EPacketEvent.IdleSpetResetResponse: return typeof(IdleRspSpetReset);
				

				case EPacketEvent.IdleLobiVoteRequest: return typeof(IdleReqYoutuber);
				case EPacketEvent.IdleLobiVoteResponse: return typeof(IdleRspYoutuber);
				

				case EPacketEvent.IdleStowerSyncRequest: return typeof(IdleReqStowerSync);
				case EPacketEvent.IdleStowerSyncResponse: return typeof(IdleRspStowerSync);
				

				case EPacketEvent.IdleStowerUpRequest: return typeof(IdleReqStowerUp);
				case EPacketEvent.IdleStowerUpResponse: return typeof(IdleRspStowerUp);
				

				case EPacketEvent.IdleStowerHatchRequest: return typeof(IdleReqStowerHatch);
				case EPacketEvent.IdleStowerHatchResponse: return typeof(IdleRspStowerHatch);
				

				case EPacketEvent.IdleStowerHoverRequest: return typeof(IdleReqStowerHover);
				case EPacketEvent.IdleStowerHoverResponse: return typeof(IdleRspStowerHover);
				

				case EPacketEvent.IdleSpetUpRequest: return typeof(IdleReqSpetUp);
				case EPacketEvent.IdleSpetUpResponse: return typeof(IdleRspSpetUp);
				

				case EPacketEvent.IdleStHchangeRequest: return typeof(IdleReqStHchange);
				case EPacketEvent.IdleStHchangeResponse: return typeof(IdleRspStHchange);
				

				case EPacketEvent.IdleNtaskSyncRequest: return typeof(IdleReqNtaskSync);
				case EPacketEvent.IdleNtaskSyncResponse: return typeof(IdleRspNtaskSync);
				

				case EPacketEvent.IdleNtaskClaimRequest: return typeof(IdleReqNtaskClaim);
				case EPacketEvent.IdleNtaskClaimResponse: return typeof(IdleRspNtaskClaim);
				

                default: return null;
            }
        }
    }
}