import Vue from 'vue';
import { Component } from 'vue-property-decorator';

@Component
export default class RouteComponent extends Vue
{
    index: number;
    title: string;
    constructor()
    {
        super();
        this.index = 0;
    }

    navigateTo()
    {
        this.$router.push({ name: "detail", params: {id: String(this.index)}});
    }
}