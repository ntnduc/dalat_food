import { lazy } from 'react';

import { RouterInterface } from './common/interface/RouterInterface';

//component
const ProductList = lazy(() => import('./page/ProductPage/ProductList/ProductList'));
const AdminPage = lazy(() => import('./page/AdminPage/AdminPage'));

const routers: RouterInterface[] = [{
    component: ProductList,
    path: '/'
}, {
    component: AdminPage,
    path: '/admin'
}];