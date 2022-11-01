# kOS-KerbalEngineer

[Kerbal Engineer](https://github.com/jrbudda/KerbalEngineer) functionality in kOS.

This mod is concerned with allowing kOS scripts to use KerbalEngineer data. 

## Example Usage

```
// get next node's half-burn-time, useful for burns you want to average over the node marker
> set bt to addons:ke:nodeHalfBurnTime.
> print bt.
11.012345

// version info
> print addons:ke:version.
kOS-KerbalEngineer: v0.1.1, KerbalEngineer: v1.1.9
```

## Burn Time Information

Both of the BurnTime values will continuously be updated, so can be read in a loop to perform precise manoeveurs, as they will decrease as the burn is made and accurately reflect the amount of time left.

Using the Half value will make a very accurate burn that averages correctly around the node.

| **Command** | **Return Type** | **Description** |
|--------|--------|--------|
|`nodeHalfBurnTime` | ScalarValue | Returns the "half time" for the burn of a node, useful for averaging the burn through its entire burn.|
|`nodeBurnTime` | ScalarValue | Returns the full burn time of a node. Not as useful as the half time.|

## Suicide Burn Information

Exposes Suicide Burn values from KerbalEngineer

| **Command** | **Return Type** | **Description** |
|--------|--------|--------|
|`suicideBurnCountdown` | ScalarValue | Returns time until suicide burn should start |
|`suicideBurnDeltaV` | ScalarValue | Returns the DeltaV of a suicide burn |
|`suicideBurnLength` | ScalarValue | Returns the duration of the suicide burn |
|`suicideBurnDistance` | ScalarValue | Returns the distance to the point at which to start a suicide burn |
|`suicideBurnAltitude` | ScalarValue | Returns the sea level altitude when to start a suicide burn |

## Thrust To Weight Ratio Information

Exposes TWR values from KerbalEngineer

| **Command** | **Return Type** | **Description** |
|--------|--------|--------|
|`actualTWR` | ScalarValue | Returns the actual TWR of the vessel at current time |
|`totalTWR` | ScalarValue | Returns the total TWR of the vessel possible at current time |

## Thermal Information

| **Command** | **Return Type** | **Description** |
|--------|--------|--------|
|`criticalPartName` | String | Returns the name of the part that is structually most critical |
|`criticalTemperature` | ScalarValue | Returns internal temperature on the part of the Vessel that is structually most critical |
|`criticalTemperatureMax` | ScalarValue | Returns maximum internal temperature of the part of the Vessel that is structually most critical |
|`criticalThermalPercentage` | ScalarValue | Returns how high a temperature the critical Part is enduring relative to it's maximal temperature as percentage (0-100) |
|`criticalSkinTemperature` | ScalarValue | Returns highest external Temperature on the part of the Vessel that is structually most critical |
|`criticalSkinTemperatureMax` | ScalarValue | Returns maximum highest external Temperature on the part of the Vessel that is structually most critical |
