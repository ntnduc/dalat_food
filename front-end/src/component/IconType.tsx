import loadable from '@loadable/component';

export const IconType = {
    'right': loadable(() => import('@ant-design/icons/RightOutlined')),
    'left': loadable(() => import('@ant-design/icons/LeftOutlined')),
} as const;

export type TIconType = keyof typeof IconType;
