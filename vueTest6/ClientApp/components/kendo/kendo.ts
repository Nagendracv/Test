import Vue from 'vue';
import { Component } from 'vue-property-decorator';

import { DataSource, DataSourceInstaller } from '@progress/kendo-datasource-vue-wrapper';

Vue.use(DataSource);

@Component
export default class KendoComponent extends Vue 
{
    localDataSource = [
        {
            "ProductID": 1,
            "ProductName": "Chai",
            "UnitPrice": 18,
            "UnitsInStock": 39,
            "Discontinued": false,
        },
        {
            "ProductID": 2,
            "ProductName": "Chang",
            "UnitPrice": 17,
            "UnitsInStock": 40,
            "Discontinued": false,
        },
        {
            "ProductID": 3,
            "ProductName": "Aniseed Syrup",
            "UnitPrice": 10,
            "UnitsInStock": 13,
            "Discontinued": false,
        },
        {
            "ProductID": 4,
            "ProductName": "Chef Anton's Cajun Seasoning",
            "UnitPrice": 22,
            "UnitsInStock": 53,
            "Discontinued": false,
        },
        {
            "ProductID": 5,
            "ProductName": "Chef Anton's Gumbo Mix",
            "UnitPrice": 21.35,
            "UnitsInStock": 0,
            "Discontinued": true,
        },
        {
            "ProductID": 6,
            "ProductName": "Grandma's Boysenberry Spread",
            "UnitPrice": 25,
            "UnitsInStock": 120,
            "Discontinued": false,
        },
        {
            "ProductID": 7,
            "ProductName": "Uncle Bob's Organic Dried Pears",
            "UnitPrice": 30,
            "UnitsInStock": 15,
            "Discontinued": false,
        }
    ];
    msg: string;
    datasource: kendo.data.DataSource;
    constructor()
    {
        super();
        this.msg = 'Kendo Grid';
        this.datasource = new kendo.data.DataSource
            ({
                transport: {
                    read: {
                        url: 'https://jsonplaceholder.typicode.com/posts',
                        dataType: 'json'
                    }
                },
                pageSize: 5
                //serverPaging: true
            });
    }

    onPageChanging()
    {
        alert("page");
    }
}