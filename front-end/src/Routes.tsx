import { RouteType } from 'domain/routeType/RouteType';
import { lazy } from 'react';

//component
const ProductList = lazy(() => import('./page/ProductPage/ProductList/ProductList'));
const AdminPage = lazy(() => import('./page/AdminPage/AdminPage'));

export const routers: RouteType[] = [{
    component: ProductList,
    path: '/product',
    name: 'Product',
    icon: 'laptop',
    isDefault: true
}, {
    component: AdminPage,
    path: '/admin',
    name: 'Admin',
    icon: 'user'
}];