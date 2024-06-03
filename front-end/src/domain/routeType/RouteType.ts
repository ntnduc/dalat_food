import { IconType } from 'antd/es/notification/interface';
import { FunctionComponent, LazyExoticComponent, ReactNode } from 'react';
import React from 'react';

export interface RouteType{
    path: string,
    component: LazyExoticComponent<FunctionComponent>,
    icon?: string,
    childrents?: RouteType[],
    name: string,
    isDefault?: boolean
}