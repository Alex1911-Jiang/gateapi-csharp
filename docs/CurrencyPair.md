
# Io.Gate.GateApi.Model.CurrencyPair

Spot currency pair

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Currency pair | [optional] 
**Base** | **string** | Base currency | [optional] 
**Quote** | **string** | Quote currency | [optional] 
**Fee** | **string** | Trading fee | [optional] 
**MinBaseAmount** | **string** | Minimum amount of base currency to trade, &#x60;null&#x60; means no limit | [optional] 
**MinQuoteAmount** | **string** | Minimum amount of quote currency to trade, &#x60;null&#x60; means no limit | [optional] 
**AmountPrecision** | **int** | Amount scale | [optional] 
**Precision** | **int** | Price scale | [optional] 
**TradeStatus** | **string** | How currency pair can be traded  - untradable: cannot be bought or sold - buyable: can be bought - sellable: can be sold - tradable: can be bought or sold | [optional] 
**EtfNetValue** | **string** | ETF net value | [optional] 
**EtfPreNetValue** | **string** | ETF previous net value at re-balancing time | [optional] 
**EtfPreTimestamp** | **long** | ETF previous re-balancing time | [optional] 
**EtfLeverage** | **string** | ETF current leverage | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
