# kOS-KerbalEngineer

[Kerbal Engineer](https://github.com/jrbudda/KerbalEngineer) functionality in kOS.

This mod is concerned with allowing kOS scripts to use KerbalEngineer data. 

## Usage

```
// get next node's half-burn-time, useful for burns you want to average over the node marker
> set bt to addons:ke:nodeHalfBurnTime.
> print bt.
11.012345

// get next node's full burn time.
> print addons:ke:nodeBurnTime.
22.567890

// version info
> print addons:ke:version.
kOS-KerbalEngineer: v0.1.0, KerbalEngineer: v1.1.9

// show help
> addons:ke:help
... (help text output)
```

## Burn Time Information

Both of the BurnTime values will continuously be updated, so can be read in a loop to perform precise manoeveurs, as they will decrease as the burn is made and accurately reflect the amount of time left.

Using the Half value will make a very accurate burn that averages correctly around the node.

| **Command** | **Return Type** | **Description** |
|--------|--------|--------|
|`nodeHalfBurnTime` | ScalarValue | Returns the "half time" for the burn of a node, useful for averaging the burn through its entire burn.|
|`nodeBurnTime` | ScalarValue | Returns the full burn time of a node. Not as useful as the half time.|
