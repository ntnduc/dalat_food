import loadable from '@loadable/component';

interface Props {
    type?: string
}

const DaLatIcon = loadable((props: Props) => import(`@ant-design/icons${props.type}`));

export default DaLatIcon;