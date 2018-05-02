import './css/site.css';
import 'bootstrap';
//import { Grid } from '../node_modules/@progress/kendo-grid-vue-wrapper/dist/npm /index.js';
import Vue from 'vue';
import VueRouter from 'vue-router';
Vue.use(VueRouter);

import '@progress/kendo-ui';
import '@progress/kendo-theme-default/dist/all.css';

import { Grid, GridInstaller } from '@progress/kendo-grid-vue-wrapper';

Vue.use(GridInstaller);


const routes = [
    { path: '/', component: require('./components/home/home.vue.html') },
    { path: '/counter', component: require('./components/counter/counter.vue.html') },
    { path: '/fetchdata', component: require('./components/fetchdata/fetchdata.vue.html') },
    { name: 'detail', path: '/detail/:id', component: require('./components/detail/detail.vue.html'), props: true},
    { name: 'route', path: '/route', component: require('./components/route/route.vue.html') },
    { name: 'kendo', path: '/kendo', component: require('./components/kendo/kendo.vue.html') }
];

new Vue({
    el: '#app-root',
    components: {
        //Grid, DataSource
    },
    router: new VueRouter({ mode: 'history', routes: routes }),
    render: h => h(require('./components/app/app.vue.html'))
    //render: h => h(require('./components/detail/detail.vue.html'))
    //render: h => h(require('./components/counter/counter.vue.html'))
});
