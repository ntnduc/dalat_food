import { FunctionComponent, LazyExoticComponent } from 'react';

export interface RouterInterface {
    path: string,
    component: LazyExoticComponent<FunctionComponent>,
    childrents?: RouterInterface[]
}