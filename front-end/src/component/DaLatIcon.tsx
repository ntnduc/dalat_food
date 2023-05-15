import Icon from '@ant-design/icons/lib/components/Icon';
import { CSSProperties } from 'react';

import { IconType, TIconType } from './IconType';

interface Props {
    iconType: TIconType,
    style?: CSSProperties
}

const DaLatIcon = (props: Props) => {
    return <Icon component={IconType[props.iconType] as React.ComponentType<React.SVGProps<SVGSVGElement>>}
        style={props.style} />;
};

export default DaLatIcon;