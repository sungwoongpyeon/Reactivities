import { Dimmer, Loader } from "semantic-ui-react";

interface Props {
  inverted?: boolean; // color dark or light
  content?: string;
}

export default function LoadingComponent({
  inverted = true,
  content = "Loading ...",
}: Props) {
  return (
    // A dimmer hides distractions to focus attention on particular content.
    <Dimmer active={true} inverted={inverted}>
      <Loader content={content} />
    </Dimmer>
  );
}
