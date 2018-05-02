import Vue from 'vue';
import { Component } from 'vue-property-decorator';

@Component
export default class CounterComponent extends Vue {
    currentcount: number = 0;
    message: string = 'first value';
    messages: string[];

    constructor() {
        super();
        this.message = 'constructor';
        this.messages = [];
    }

    incrementCounter() {
        this.currentcount++;
    }

    get messageLength(): number {
        return this.message.length;
    }

    messageLength2(): number {
        return this.message.length;
    }

    addItem() {
        
        if (this.message.length > 0)
        {
            this.messages.push(this.message);
            this.message = '';
        }
    }

    removeItem(index: number)
    {
        this.messages.splice(index, 1);
    }
}
