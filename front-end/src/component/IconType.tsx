import loadable from '@loadable/component';


export const IconType = {
    'right': loadable(() => import('@ant-design/icons/RightOutlined')),
    'left': loadable(() => import('@ant-design/icons/LeftOutlined')),
    'share': loadable(() => import('../icon_source/IconShareComponent'))
} as const;

export type TIconType = keyof typeof IconType;