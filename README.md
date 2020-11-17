### Dot Repo

A library to handle all the data retrieval part right now supporting JSON file and postgres DB

###

Add this configuration to map the table and column to the properties of the entity.

```json
"DataMapping": {
    "PropertyMap": {
        "Id": "col1",
        "Prop1": "col2"
    },
    "TableName":"table1",
    "Keys":["Id"]
    }
```

To use Json FIle Data loader add this in app settings

```json
"FileRepository": {
    "Model1": "wwwroot/data/model1_data.json",
    "Model2": "wwwroot/data/model2_data.json"
  }
```