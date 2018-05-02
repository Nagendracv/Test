import Vue from 'vue';
import { Component } from 'vue-property-decorator';
import { Prop } from "vue-property-decorator"
import IComment from "../../interfaces/IComment";
import Comment from "../../data_models/Comment";

@Component({
    props: { id: String}
})
export default class DetailComponent extends Vue
{
    id: string;
    //nid: number;
    title: string ;
    body: string ;

    constructor()
    {
        super();
        //this.id = '0';
        //this.nid = 0;
        this.title = 'start title';
        this.body = 'start body'
    }

    mounted() {
        //alert(this.id);
        //this.nid = parseInt(this.$route.params.id);
        fetch('https://jsonplaceholder.typicode.com/posts/' + this.id )//this.$route.params.id)
            .then(response => response.json() as Promise<Comment>)
            .then(data => {
                this.title = data.title;
                this.body = data.body;
            });
    }
}